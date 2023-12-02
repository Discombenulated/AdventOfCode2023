using NUnit.Framework;
using AdventOfCode.Day02;

namespace AdventOfCode.Test.Day02;

public class Task01
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RoundIsPossible(){
        var bag = new CubeBag(2, 2, 2);
        var round = new CubeGameRound(2, 2, 2);
        Assert.IsTrue(round.IsPossible(bag));
        round = new CubeGameRound(2, 3, 4);
        Assert.IsFalse(round.IsPossible(bag));
    }

    [Test]
    public void CanCreateRoundFromString(){
        var bag = new CubeBag(5, 4, 4);
        var round = CubeGameRound.Parse("3 blue, 4 green, 5 red");
        Assert.IsTrue(round.IsPossible(bag));
        round = CubeGameRound.Parse("3 green, 4 blue, 6 red");
        Assert.IsFalse(round.IsPossible(bag));
    }

    [Test]
    public void GameIsPossibleIfAllRoundsArePossible(){
        var round1 = new CubeGameRound(2, 2, 2);
        var game = new CubeGame(round1);
        Assert.IsTrue(game.IsPossible(new CubeBag(2, 2, 2)));
        Assert.IsFalse(game.IsPossible(new CubeBag(1, 1, 1)));
    }

    [Test]
    public void CanCreateGameFromString(){
        var game = CubeGame.Parse("3 blue, 4 green, 5 red; 4 blue, 16 green");
        Assert.IsTrue(game.IsPossible(new CubeBag(5, 16, 4)));
        Assert.IsFalse(game.IsPossible(new CubeBag(0, 0, 0)));
    }

    [Test]
    public void CanSumIdsOfPossibleGames(){
        var bag = new CubeBag(3,4,16);
        var game = CubeGame.Parse("3 red, 4 green, 5 blue; 4 green, 16 blue");
        var gameList = new CubeGameList(game);
        Assert.AreEqual(1, gameList.SumIdsOfPossibleGames(bag));

        gameList = new CubeGameList(game, game);
        Assert.AreEqual(3, gameList.SumIdsOfPossibleGames(bag));
    }

    [Test]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day02/ExampleInput.txt").ReadLines();
        var gameList = CubeGameList.Parse(input);
        var bag = new CubeBag(12, 13, 14);
        Assert.AreEqual(8, gameList.SumIdsOfPossibleGames(bag));
    }

    [Test]
    public void Test_MyData()
    {
        var input = new FileInput("Day02/MyInput.txt").ReadLines();
        var gameList = CubeGameList.Parse(input);
        var bag = new CubeBag(12, 13, 14);
        Assert.AreEqual(2541, gameList.SumIdsOfPossibleGames(bag));
    }
}