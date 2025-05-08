public static long aVeryBigSum(List<long> ar)
    {
        long bigSum = 0;
        foreach(int i in ar)
        {
            bigSum += i;
        }        
        return bigSum;
    }
