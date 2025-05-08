public static void miniMaxSum(List<int> arr)
    {
        long min = 0, max = 0;
        arr.Sort();
        for (int i = 0; i < 4; i++)
        {
           min += arr[i];
        }

         for (int i = 4; i > 0; i--)
         {
           max += arr[i];
         }
         Console.WriteLine($"{min} {max}");
    }
