using NUnit.Framework;
using AdventOfCode.Day03;

namespace AdventOfCode.Test.Day03;

public class Task01
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void NotAPartNumber(){
        var schematic = new EngineSchematic("...", ".1.","...");
        Assert.AreEqual(0,schematic.SumOfPartNumbers());
    }

    [Test]
    public void SingleDigitPartNumber_Up(){
        var schematic = new EngineSchematic(".*.", ".1.","...");
        Assert.AreEqual(1,schematic.SumOfPartNumbers());
        schematic = new EngineSchematic(".1.", "...","...");
        Assert.AreEqual(0,schematic.SumOfPartNumbers());
        schematic = new EngineSchematic(".*.", ".23","...");
        Assert.AreEqual(23,schematic.SumOfPartNumbers());
        schematic = new EngineSchematic("..*", ".23","...");
        Assert.AreEqual(23,schematic.SumOfPartNumbers());
    }

    [Test]
    public void PartNumber_Down(){
        var schematic = new EngineSchematic("...", ".1.",".*.");
        Assert.AreEqual(1,schematic.SumOfPartNumbers());
        schematic = new EngineSchematic("...", "...",".1.");
        Assert.AreEqual(0,schematic.SumOfPartNumbers());
        schematic = new EngineSchematic("...", ".12",".*.");
        Assert.AreEqual(12,schematic.SumOfPartNumbers());
        schematic = new EngineSchematic("...", ".12","..*");
        Assert.AreEqual(12,schematic.SumOfPartNumbers());

        schematic = new EngineSchematic("...", "3.2","*.*");
        Assert.AreEqual(5,schematic.SumOfPartNumbers());
        schematic = new EngineSchematic("...", "3.2","*..");
        Assert.AreEqual(3,schematic.SumOfPartNumbers());
        schematic = new EngineSchematic("...", "3.2","..*");
        Assert.AreEqual(2,schematic.SumOfPartNumbers());
    }

    [Test]
    public void PartNumber_LeftOrRight(){
        var schematic = new EngineSchematic("...", "*1.","...");
        Assert.AreEqual(1,schematic.SumOfPartNumbers());
        schematic = new EngineSchematic("...", ".1*","...");
        Assert.AreEqual(1,schematic.SumOfPartNumbers());
        schematic = new EngineSchematic("...", "13*","...");
        Assert.AreEqual(13,schematic.SumOfPartNumbers());
        schematic = new EngineSchematic("...", "*13","...");
        Assert.AreEqual(13,schematic.SumOfPartNumbers());
        schematic = new EngineSchematic("...", "1*3","...");
        Assert.AreEqual(4,schematic.SumOfPartNumbers());
    }

    [Test]
    public void PartNumber_Diagonals(){
        var schematic = new EngineSchematic("*..", ".1.","...");
        Assert.AreEqual(1,schematic.SumOfPartNumbers());
        schematic = new EngineSchematic("..*", ".1.","...");
        Assert.AreEqual(1,schematic.SumOfPartNumbers());
        schematic = new EngineSchematic("...", ".1.","*..");
        Assert.AreEqual(1,schematic.SumOfPartNumbers());
        schematic = new EngineSchematic("...", ".1.","..*");
        Assert.AreEqual(1,schematic.SumOfPartNumbers());
    }

    [Test]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day03/ExampleInput.txt").ReadLines();
        var schematic = new EngineSchematic(input);
        Assert.AreEqual(4361,schematic.SumOfPartNumbers());
    }

    [Test]
    public void Test_MyData()
    {
        var input = new FileInput("Day03/MyInput.txt").ReadLines();
        var schematic = new EngineSchematic(input);
        Assert.AreEqual(525911,schematic.SumOfPartNumbers());
    }
}