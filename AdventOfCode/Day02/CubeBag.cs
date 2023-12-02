
namespace AdventOfCode.Day02;

public class CubeBag
{
    public CubeBag(int red, int green, int blue){
        Red = red;
        Green = green;
        Blue = blue;
    }

    public int Red { get; }
    public int Green { get; }
    public int Blue { get; }

    public override bool Equals(object? obj)
    {
        return obj is CubeBag bag &&
               Red == bag.Red &&
               Green == bag.Green &&
               Blue == bag.Blue;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Red, Green, Blue);
    }

    public override string ToString()
    {
        return $"{Red}, {Green}, {Blue}";
    }
}