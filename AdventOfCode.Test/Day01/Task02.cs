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
    public void OverlappingTextIsStillTwoNumbers(){
        Assert.AreEqual(82, new CalibrationTextLine("eightwo").Value());
    }

    [Test]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day01/Example2Input.txt").ReadLines();
        Assert.AreEqual(281, new Calibration(input, Calibration.DigitsAndText).Sum());
    }

    [Test]
    public void Test_MyData()
    {
        var input = new FileInput("Day01/MyInput.txt").ReadLines();
    }
}