using System.Numerics;

namespace AdventOfCode.Day01;

public class CalibrationLine
{
    private readonly string line;
    public CalibrationLine(string line){
        this.line = line;
    }

    public int Value(){
        int indexOfFirstDigit = fromLeft();
        int indexOfSecondDigit = fromRight();
        var digits = line[indexOfFirstDigit].ToString() + line[indexOfSecondDigit].ToString();
        return int.Parse(digits);
    }

    private int fromLeft(){
        for (int i = 0; i < line.Length; i++){
            char c = line[i];
            int digit;
            if (int.TryParse(c.ToString(), out digit)){
                return i;
            }
        }
        throw new Exception("No integers in line");
    }

    private int fromRight(){
        for (int i = line.Length - 1; i >= 0; i--){
            char c = line[i];
            int digit;
            if (int.TryParse(c.ToString(), out digit)){
                return i;
            }
        }
        throw new Exception("No integers in line");
    }
}