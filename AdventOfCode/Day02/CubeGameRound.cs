namespace AdventOfCode.Day02;

public class CubeGameRound
{
    private readonly int numRed;
    private readonly int numGreen;
    private readonly int numBlue;

    public CubeGameRound(int numRed, int numGreen, int numBlue){
        this.numRed = numRed;
        this.numGreen = numGreen;
        this.numBlue = numBlue;
    }

    public static CubeGameRound Parse(string input){
        var components = input.Split(", ");
        int red = 0, green = 0, blue = 0;
        foreach (var component in components){
            var colorAndNum = component.Split(" ");
            var color = colorAndNum[1];
            var num = int.Parse(colorAndNum[0]);
            switch(color){
                case "red":
                    red += num;
                    break;
                case "blue":
                    blue += num;
                    break;
                case "green":
                    green += num;
                    break;
                default:
                    throw new Exception("Unknow color: " + color);
            }
        }
        return new CubeGameRound(red, green, blue);
    }

    public bool IsPossible(CubeBag bag){
        return this.numRed <= bag.Red &&
            this.numGreen <= bag.Green &&
            this.numBlue <= bag.Blue;
    }

    public CubeBag GetMinimumBag(CubeBag bag){
        return new CubeBag(
            Math.Max(bag.Red, this.numRed),
            Math.Max(bag.Green, this.numGreen),
            Math.Max(bag.Blue, this.numBlue)
        );
    }
}