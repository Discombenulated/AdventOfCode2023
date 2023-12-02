using System.Numerics;

namespace AdventOfCode.Day02;

public class CubeGameList
{
    private readonly CubeGame[] games;

    public CubeGameList(params CubeGame[] games){
        this.games = games;
    }

    public int SumIdsOfPossibleGames(int minRed, int minGreen, int minBlue){
        int idSum = 0;
        for (int i = 0; i < games.Length; i++){
            if (games[i].IsPossible(minRed, minGreen, minBlue)){
                idSum += (i+1);
            }
        }
        return idSum;
    }
}