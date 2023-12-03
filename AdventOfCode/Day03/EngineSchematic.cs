using System.Security.Cryptography.X509Certificates;

namespace AdventOfCode.Day03;

public class EngineSchematic{

    private static readonly char DEFAULT_CHAR = '.';
    private readonly string[] lines;

    public EngineSchematic(params string[] lines){
        this.lines = lines;
    }

    public int SumOfPartNumbers(){
        int partNumberSum = 0;
        for (int y = 0; y < lines.Length; y++){
            string currentNumStr = "";
            bool currentNumIsPartNum = false;
            for (int x = 0; x < lines[y].Length; x++){
                if (IsNumberAt(x,y)){
                    var currentChar = GetCharAt(x, y);
                    currentNumStr += currentChar.ToString();
                    currentNumIsPartNum = currentNumIsPartNum || 
                                            IsSymbolAt(x, y-1) || 
                                            IsSymbolAt(x, y+1);
                    if (currentNumStr.Length == 1){
                        currentNumIsPartNum = currentNumIsPartNum || IsSymbolAt(x-1, y)
                                                                || IsSymbolAt(x-1, y+1)
                                                                || IsSymbolAt(x-1, y-1);
                    }
                    if (IsNumberAt(x+1,y)) {
                        continue; //Not yet at the end of the number
                    } else {
                        //Have reached the end of the number.
                        currentNumIsPartNum = currentNumIsPartNum || IsSymbolAt(x+1, y)
                                                                  || IsSymbolAt(x+1, y+1)
                                                                  || IsSymbolAt(x+1, y-1);
                        if (currentNumIsPartNum){
                            partNumberSum += int.Parse(currentNumStr);
                        }
                        currentNumStr = "";
                        currentNumIsPartNum = false;
                    }
                }
            }
        }
        return partNumberSum;
    }

    private char GetCharAt(int x, int y){
        if (y < 0 || y >= lines.Length) return DEFAULT_CHAR;
        if (x < 0 || x >= lines[y].Length) return DEFAULT_CHAR;
        return lines[y][x];
    }

    private bool IsNumberAt(int x, int y){
        var digit = GetCharAt(x, y).ToString();
        return IsNumber(digit);
    }

    private bool IsNumber(string digit){
        return int.TryParse(digit, out int num);
    }

    private bool IsSymbolAt(int x, int y){
        var digit = GetCharAt(x, y).ToString();
        return !(digit.Equals(".") || IsNumber(digit));
    }
}