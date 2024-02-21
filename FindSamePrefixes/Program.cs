using System.Text;

public static class Program
{
    public static void Main()
    {
        string[] array = { "floor", "flower", "flight" };
        Console.WriteLine(LongestCommonPrefix(array));
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        StringBuilder sb = new();

        for (int i = 0; i < strs[0].Length; i++)
        {
            char currentChar = strs[0][i];
            bool allSame = true;

            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[j].Length == i || strs[j][i] != currentChar)
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

        return sb.ToString();
    }
}


