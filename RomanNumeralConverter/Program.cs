namespace RomanNumeralConverter;

public static class Program
{
    private static readonly Dictionary<char, int> romanDict = new()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public static void Main()
    {
        Console.WriteLine(RomanToInt_V1("MMCCXXXIX")); // 2239
        Console.WriteLine(RomanToInt_V2("MMCCXXXIX")); // 2239
    }

    public static int RomanToInt_V1(string s)
    {
        int romanSum = 0;
        int lastValue = 0;
        for (var i = 0; i < s.Length; i++)
        {
            int currentValue = romanDict[s[i]];
            if (currentValue > lastValue)
                romanSum += currentValue - 2 * lastValue;
            else
                romanSum += currentValue;

            lastValue = currentValue;
        }

        return romanSum;
    }

    public static int RomanToInt_V2(string s)
    {
        int romanSum = 0;
        int prevValue = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            int currentValue = romanDict[s[i]];
            if (prevValue <= currentValue)
                romanSum += currentValue;
            else
                romanSum -= currentValue;

            prevValue = currentValue;
        }

        return romanSum;
    }
}