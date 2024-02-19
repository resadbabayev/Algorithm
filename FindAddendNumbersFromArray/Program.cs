int[] arr = { 1, -4, -7, 6, 9, 10, 15, 3 };
const int target = 8;

Dictionary<int, int> dictionary = new();
for (int i = 0; i < arr.Length; i++)
{
    int item = arr[i];

    if (dictionary.ContainsKey(target - item))
    {
        Console.WriteLine($"{dictionary[target - item]}, {i}");
    }
    else
    {
        dictionary.Add(item, i);
    }
}

Console.ReadLine();