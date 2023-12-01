using NUnit.Framework;
using AdventOfCode.Day01;

namespace AdventOfCode.Test.Day01;

public class Task02
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CanReadDigitAsText(){
        Assert.AreEqual(13, new CalibrationTextLine("heonele3").Value());
    }

    [Test]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day01/ExampleInput.txt").ReadLines();
    }

    [Test]
    public void Test_MyData()
    {
        var input = new FileInput("Day01/MyInput.txt").ReadLines();
    }
}