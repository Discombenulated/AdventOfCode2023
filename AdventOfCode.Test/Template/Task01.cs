using NUnit.Framework;

namespace AdventOfCode.Test.Template;

public class Task01
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [Ignore("Template test")]
    public void Test_ExampleData()
    {
        var input = new FileInput("DayXX/ExampleInput.txt").ReadLines();
    }

    [Test]
    [Ignore("Template test")]
    public void Test_MyData()
    {
        var input = new FileInput("DayXX/MyInput.txt").ReadLines();
    }
}