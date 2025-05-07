public static void miniMaxSum(List<int> arr)
    {
        arr.Sort();
        long min = 0;
        long max = 0;
        for(int i = 0; i < 4; i++)
        {
            min += arr[i];
        }
        
        for(int i = 4; i >0; i--)
        {
            max += arr[i];
        }
        Console.WriteLine(min+" "+max);

    }
