using NUnit.Framework;

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
    public void Test_MyData()
    {
        var input = new FileInput("Day01/MyInput.txt").ReadLines();
    }
}