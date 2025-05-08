public static int birthdayCakeCandles(List<int> candles)
    {
        candles.Sort();
        int n = candles.Count;
        int sayac = candles[n-1];
        int sayici = 0;
        for(int i= 0; i<n;i++)
        {
            if(candles[i] == sayac)
            {
                sayici++;
            }
        }
        return sayici;

    }
