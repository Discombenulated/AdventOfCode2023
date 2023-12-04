using NUnit.Framework;
using AdventOfCode.Day04;

namespace AdventOfCode.Test.Day04;

public class Task01
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CardWithNoWinningNumbersIsWorthNoPoints(){
        var card = new ScratchCard(1, 2, 3, 4, 5, 6, 7, 8);
        Assert.AreEqual(0, card.PointsScoredWith(99,98,97,96,95));
    }

    [Test]
    public void CanCalculatePointsOnWinningCards(){
        var card = new ScratchCard(1, 2, 3, 4, 5, 6, 7, 8);
        Assert.AreEqual(1, card.PointsScoredWith(4,98,97,96,95));
        card = new ScratchCard(1, 2, 3, 4, 5, 6, 7, 8);
        Assert.AreEqual(2, card.PointsScoredWith(1,2,97,96,95));
        card = new ScratchCard(1, 2, 3, 4, 5, 6, 7, 8);
        Assert.AreEqual(4, card.PointsScoredWith(1,2,6,96,95));
    }

    [Test]
    public void CanReadCardFromString(){
        var result = ScratchCard.ParseForPoints("Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53");
        Assert.AreEqual(8, result);
    }

    [Test]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day04/ExampleInput.txt").ReadLines();
        Assert.AreEqual(13, ScratchCard.ParseForPoints(input));
    }

    [Test]
    public void Test_MyData()
    {
        var input = new FileInput("Day04/MyInput.txt").ReadLines();
        Assert.AreEqual(19855, ScratchCard.ParseForPoints(input));
    }
}