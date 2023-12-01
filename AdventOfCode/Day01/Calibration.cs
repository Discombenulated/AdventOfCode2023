using System.Numerics;

namespace AdventOfCode.Day01;

public class Calibration
{
    public delegate CalibrationLine CreateLineDelegate(string line);
    private readonly string[] lines;
    private readonly CreateLineDelegate lineFactory;

    public Calibration(string[]lines) : this(lines, delegate(string line) {return new CalibrationLine(line);})
    {}

    public Calibration(string[] lines, CreateLineDelegate lineFactory){
        this.lines = lines;
        this.lineFactory = lineFactory;
    }

    public int Sum(){
        int sum = 0;
        foreach (var line in lines){
            sum += this.lineFactory(line).Value();
        }
        return sum;
    }
}