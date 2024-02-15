int[] arr1 = { 1, 1, 77, 2, 43, 234, 9, 2, 8 };
int[] arr2 = { 344, 77, 11, 1, 1, 25, 90, 111 };

printIntersection1(arr1, arr2);
printIntersection2(arr1, arr2);

static void printIntersection1(int[] arr1, int[] arr2)
{
    Console.WriteLine("method 1");

    var set = new HashSet<int>(arr2, null);
    foreach (int element in arr1)
        if (set.Remove(element))
            Console.WriteLine(element);
}

static void printIntersection2(int[] arr1, int[] arr2)
{
    Console.WriteLine("method 2");

    Array.Sort(arr1);
    Array.Sort(arr2);

    int i = 0, j = 0;

    while (i < arr1.Length && j < arr2.Length)
    {
        if (arr1[i] < arr2[j])
            i++;

        else if (arr2[j] < arr1[i])
            j++;

        else
        {
            Console.WriteLine(arr2[j++]);
            i++;
        }
    }
}