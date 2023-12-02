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
    public void SimpleGameIsPossible(){
        var game = new CubeGame(2, 2, 2);
        Assert.IsTrue(game.IsPossible(2, 2, 2));
        game = new CubeGame(2, 3, 4);
        Assert.IsTrue(game.IsPossible(2, 2, 2));
    }

    [Test]
    public void SimpleGameIsNotPossible(){
        var game = new CubeGame(2, 2, 2);
        Assert.IsFalse(game.IsPossible(3, 3, 3));
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