public static void plusMinus(List<int> arr)
    {
        int total = arr.Count;
    int posCount = 0, negCount = 0, zeroCount = 0;

    foreach (int num in arr)
    {
        if (num > 0)
            posCount++;
        else if (num < 0)
            negCount++;
        else
            zeroCount++;
    }

    Console.WriteLine("{0:F6}", (double)posCount / total);
    Console.WriteLine("{0:F6}", (double)negCount / total);
    Console.WriteLine("{0:F6}", (double)zeroCount / total);

    }
