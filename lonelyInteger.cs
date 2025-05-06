 public static int lonelyinteger(List<int> a)
    {
        int result = 0;
        foreach (int num in a)
        {
             result ^= num;
        }
        return result;
    }
