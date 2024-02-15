var array = new[] { 19, 2, 55, 34, 7, 88, 123, 1, 5, 66 };

int max1 = 0, max2 = 0;

for (int i = 0; i < array.Length; i++)
{
    int item = array[i];

    if (i == 0)
    {
        max1 = max2 = item;
    }


    if (item > max1)
    {
        max2 = max1;
        max1 = item;
    }
    else
    {
        if (item > max2)
            max2 = item;
    }
}

Console.WriteLine(max1);
Console.WriteLine(max2);
Console.ReadLine();