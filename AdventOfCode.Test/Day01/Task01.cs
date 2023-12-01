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
    }

    [Test]
    public void CalibrationValueFromOneLineContainingTwoDigits(){
        Assert.AreEqual(43, new CalibrationLine("ab4cd3").Value());
        Assert.AreEqual(34, new CalibrationLine("a3cd4").Value());
    }

    [Test]
    public void Test_MyData()
    {
        var input = new FileInput("Day01/MyInput.txt").ReadLines();
    }
}