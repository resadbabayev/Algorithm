string input = "MMCCXXXIX"; // 2239

Dictionary<char, int> dictionary = new()
    {
        { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 },
        { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
    };

int result = 0;
int lastValue = 0;

foreach (char symbol in input)
{
    int currentValue = dictionary[symbol];

    if (currentValue > lastValue)
        result += currentValue - 2 * lastValue;
    else
        result += currentValue;

    lastValue = currentValue;
}

Console.WriteLine(result);
Console.ReadLine();