namespace AdventOfCode.Day02;

public class CubeGame
{
    private readonly CubeGameRound[] rounds;

    public CubeGame(params CubeGameRound[] rounds){
        this.rounds = rounds;
    }

    public static CubeGame Parse(string input){
        var roundsAsStrings = input.Split("; ");
        var rounds = new List<CubeGameRound>();
        foreach(var round in roundsAsStrings){
            rounds.Add(CubeGameRound.Parse(round));
        }
        return new CubeGame(rounds.ToArray());
    }

    public bool IsPossible(int minRed, int minGreen, int minBlue){
        foreach (var round in rounds){
            if (!round.IsPossible(minRed, minGreen, minBlue)){
                return false;
            }
        }
        return true;
    }
}