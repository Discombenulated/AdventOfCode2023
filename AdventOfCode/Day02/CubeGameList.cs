namespace AdventOfCode.Day02;

public class CubeGameList
{
    private readonly CubeGame[] games;

    public CubeGameList(params CubeGame[] games){
        this.games = games;
    }

    public static CubeGameList Parse(string[] input){
        var games = new List<CubeGame>();
        foreach(var line in input){
            var gameAsString = line.Split(": ")[1];
            games.Add(CubeGame.Parse(gameAsString));
        }
        return new CubeGameList(games.ToArray());
    }

    public int SumIdsOfPossibleGames(CubeBag bag){
        int idSum = 0;
        for (int i = 0; i < games.Length; i++){
            if (games[i].IsPossible(bag)){
                idSum += (i+1);
            }
        }
        return idSum;
    }

    public int SumOfCubePowers(){
        int sum = 0;
        foreach (var game in games){
            sum += game.PowerOfCubes();
        }
        return sum;
    }
}