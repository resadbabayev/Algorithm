const string input = "{[()]}";
bool result = FindResult(input);
Console.WriteLine(result);

Console.ReadLine();

static bool FindResult(string input)
{
    Stack<char> output = new();

    foreach (char symbol in input)
    {
        if (symbol is '{' or '[' or '(')
        {
            output.Push(symbol);
        }

        else if (symbol is '}' or ']' or ')')
        {
            if (output.Count == 0)
            {
                return false;
            }

            char top = output.Pop();
            switch (symbol)
            {
                case '}' when top != '{':
                case ']' when top != '[':
                case ')' when top != '(':
                    return false;
            }
        }
    }

    return output.Count == 0;
}