using NUnit.Framework;
using AdventOfCode.Day02;

namespace AdventOfCode.Test.Day02;

public class Task02
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GameCanCalculateMinimumBagRequired(){
        var game = CubeGame.Parse("3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green");
        Assert.AreEqual(new CubeBag(4, 2, 6), game.MinimumBag());
    }

    [Test]
    public void GameCanCalculatePowerOfCubes(){
        var game = CubeGame.Parse("3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green");
        Assert.AreEqual(48, game.PowerOfCubes());
    }

    [Test]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day02/ExampleInput.txt").ReadLines();
        var gameList = CubeGameList.Parse(input);
        Assert.AreEqual(2286, gameList.SumOfCubePowers());
    }

    [Test]
    public void Test_MyData()
    {
        var input = new FileInput("Day02/MyInput.txt").ReadLines();
        var gameList = CubeGameList.Parse(input);
        Assert.AreEqual(66016, gameList.SumOfCubePowers());
    }
}