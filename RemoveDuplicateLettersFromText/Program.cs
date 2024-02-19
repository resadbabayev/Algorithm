using System.Text;

const string text = "aabbbacdeeef";

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