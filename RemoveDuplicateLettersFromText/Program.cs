using System.Text;

const string text = "aabbbacdeeef";

Console.WriteLine(text[2..3]);

if (text.Length > 0)
{
    StringBuilder sb = new(text[0].ToString());

    foreach (char letter in text)
    {
        if (sb[^1] != letter)
            sb.Append(letter);
    }

    Console.WriteLine(sb.ToString());
    Console.ReadLine();
}