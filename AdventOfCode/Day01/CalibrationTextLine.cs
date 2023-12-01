using System.Numerics;

namespace AdventOfCode.Day01;

public class CalibrationTextLine : CalibrationLine
{
    public CalibrationTextLine(string line) : base(NormaliseLine(line)){
    }

    private static string NormaliseLine(string line){
        return line.Replace("one", "1")
                   .Replace("two", "2")
                   .Replace("three", "3")
                   .Replace("four", "4")
                   .Replace("five", "5")
                   .Replace("six", "6")
                   .Replace("seven", "7")
                   .Replace("eight", "8")
                   .Replace("nine", "9");
    }
}