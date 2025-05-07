public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        List<int> result = new List<int>(){0,0};
        result[0] = 0;
        result[1] = 0;
        for(int i = 0; i < a.Count;i++)
        {
            if(a[i] > b[i])
            {
                result[0] += 1;
            }
            else if(a[i] < b[i])
            {
                result[1] += 1;
            }
            else
            {
                continue;
                
            }
        }
        return result; 
    }
