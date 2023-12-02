using System.Numerics;

namespace AdventOfCode.Day02;

public class CubeGame
{
    private readonly int numRed;
    private readonly int numGreen;
    private readonly int numBlue;

    public CubeGame(int numRed, int numGreen, int numBlue){
        this.numRed = numRed;
        this.numGreen = numGreen;
        this.numBlue = numBlue;
    }

    public bool IsPossible(int maxRed, int maxGreen, int maxBlue){
        return true;
    }
}