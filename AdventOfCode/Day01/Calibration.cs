using System.Numerics;

namespace AdventOfCode.Day01;

public class Calibration
{
    public delegate CalibrationLine CreateLineDelegate(string line);
    public static readonly CreateLineDelegate DigitsOnly = delegate(string line) {return new CalibrationLine(line);};
    public static readonly CreateLineDelegate DigitsAndText = delegate(string line) {return new CalibrationTextLine(line);};
    private readonly string[] lines;
    private readonly CreateLineDelegate lineFactory;

    public Calibration(string[]lines) : this(lines, DigitsOnly)
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