using System.Numerics;

namespace AdventOfCode.Day01;

public class CalibrationTextLine : CalibrationLine
{
    public CalibrationTextLine(string line) : base(NormaliseLine(line)){
    }

    private static string NormaliseLine(string line){
        string newline = line.Replace("one", "o1e")
                   .Replace("two", "t2o")
                   .Replace("three", "t3e")
                   .Replace("four", "f4r")
                   .Replace("five", "f5e")
                   .Replace("six", "s6x")
                   .Replace("seven", "s7n")
                   .Replace("eight", "e8t")
                   .Replace("nine", "n9e");
        return newline;
    }
}