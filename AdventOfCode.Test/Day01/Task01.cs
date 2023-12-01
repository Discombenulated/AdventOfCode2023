using NUnit.Framework;
using AdventOfCode.Day01;

namespace AdventOfCode.Test.Day01;

public class Task01
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day01/ExampleInput.txt").ReadLines();
        Assert.AreEqual(142, new Calibration(input).Sum());
    }

    [Test]
    public void CalibrationValueFromOneLineContainingTwoDigits(){
        Assert.AreEqual(43, new CalibrationLine("ab4cd3").Value());
        Assert.AreEqual(34, new CalibrationLine("a3cd4").Value());
    }

    [Test]
    public void CalibrationValueFromOneLineContainingOneDigits(){
        Assert.AreEqual(44, new CalibrationLine("ab4cd").Value());
        Assert.AreEqual(33, new CalibrationLine("abcd3").Value());
    }

    [Test]
    public void CalibrationFileCanSumAllLineValues(){
        string[] lines = {"abc13de", "f5g9"};
        Assert.AreEqual(72, new Calibration(lines).Sum());
    }

    [Test]
    public void Test_MyData()
    {
        var input = new FileInput("Day01/MyInput.txt").ReadLines();
        Assert.AreEqual(53334, new Calibration(input).Sum());
    }
}