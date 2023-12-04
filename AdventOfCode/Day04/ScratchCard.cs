namespace AdventOfCode.Day04;

public class ScratchCard{
    private readonly int[] numbers;

    public ScratchCard(params int[] numbers){
        this.numbers = numbers;
    }

    public static int ParseForPoints(string input){
        var parts = input.Split("|");
        var cardNums = parts[1].Split(" ")
                               .Where(a => !String.IsNullOrWhiteSpace(a))
                               .Select(a => int.Parse(a))
                               .ToArray();
        var winningNumbers = parts[0].Split(":")[1]
                               .Split(" ")
                               .Where(b => !String.IsNullOrWhiteSpace(b))
                               .Select(a => int.Parse(a))
                               .ToArray();
        return new ScratchCard(cardNums).PointsScoredWith(winningNumbers);
    }

    public static int ParseForPoints(string[] input){
        var pointsTotal = 0;
        foreach (var line in input){
            pointsTotal += ParseForPoints(line);
        }
        return pointsTotal;
    }

    public int PointsScoredWith(params int[] winningNumbers){
        var numbersInBoth = numbers.Intersect(winningNumbers);
        return (int)Math.Pow(2, numbersInBoth.Count()-1);
    }
}