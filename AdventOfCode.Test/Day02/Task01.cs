using NUnit.Framework;

namespace AdventOfCode.Test.Day02;

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
        var input = new FileInput("Day02/ExampleInput.txt").ReadLines();
    }

    [Test]
    [Ignore("Template test")]
    public void Test_MyData()
    {
        var input = new FileInput("Day02/MyInput.txt").ReadLines();
    }
}