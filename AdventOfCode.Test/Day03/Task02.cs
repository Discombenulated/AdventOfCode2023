using NUnit.Framework;

namespace AdventOfCode.Test.Day03;

public class Task02
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [Ignore("Template test")]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day03/ExampleInput.txt").ReadLines();
    }

    [Test]
    [Ignore("Template test")]
    public void Test_MyData()
    {
        var input = new FileInput("Day03/MyInput.txt").ReadLines();
    }
}