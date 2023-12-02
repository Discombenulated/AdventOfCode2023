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
        var round = new CubeGameRound(2, 2, 2);
        Assert.IsTrue(round.IsPossible(2, 2, 2));
        round = new CubeGameRound(2, 3, 4);
        Assert.IsTrue(round.IsPossible(2, 2, 2));
    }

    [Test]
    public void SimpleRoundIsNotPossible(){
        var round = new CubeGameRound(2, 2, 2);
        Assert.IsFalse(round.IsPossible(3, 3, 3));
    }

    [Test]
    public void CanCreateRoundFromString(){
        var round = CubeGameRound.Parse("3 blue, 4 green, 5 red");
        Assert.IsTrue(round.IsPossible(5, 4, 3));
        round = CubeGameRound.Parse("3 green, 4 blue, 5 red");
        Assert.IsFalse(round.IsPossible(5, 4, 3));
    }

    [Test]
    public void GameIsPossibleIfAllRoundsArePossible(){
        var round1 = new CubeGameRound(2, 2, 2);
        var game = new CubeGame(round1);
        Assert.IsTrue(game.IsPossible(1,1,1));
        Assert.IsFalse(game.IsPossible(1,1,3));
    }

    [Test]
    [Ignore("Template test")]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day02/ExampleInput.txt").ReadLines();
    }

    [Test]
    [Ignore("Template test")]
    public void Test_MyData()
    {
        var input = new FileInput("Day02/MyInput.txt").ReadLines();
    }
}