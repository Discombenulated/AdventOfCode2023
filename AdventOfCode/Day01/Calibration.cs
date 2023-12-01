using System.Numerics;

namespace AdventOfCode.Day01;

public class Calibration
{
    private readonly string[] lines;
    public Calibration(string[] lines){
        this.lines = lines;
    }

    public int Sum(){
        int sum = 0;
        foreach (var line in lines){
            sum += new CalibrationLine(line).Value();
        }
        return sum;
    }
}