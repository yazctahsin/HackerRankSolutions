public static string gameOfStones(int n)
    {
        if(n % 7 == 1 || n % 7 == 0)
        {
            return "Second";
        }
        else return "First";

    }
