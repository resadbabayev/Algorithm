using System.Text;


string[] array = { "flower", "floor", "flight" };

StringBuilder sb = new();

int minLength = array[0].Length;

for (int i = 0; i < minLength; i++)
{
    char currentChar = array[0][i];
    bool allSame = true;

    for (int j = 1; j < array.Length; j++)
    {
        if (array[j][i] != currentChar)
        {
            allSame = false;
            break;
        }
    }

    if (allSame)
    {
        sb.Append(currentChar);
    }
    else
    {
        break;
    }
}

Console.WriteLine(sb.ToString());
Console.ReadLine();

