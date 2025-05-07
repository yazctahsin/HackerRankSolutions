public static int palindromeIndex(string s)
    {
        int n = s.Length;
        for(int i = 0; i < n/2;i++){
            if(s[i] != s[n-1-i])
            {
                if (palindromMu(s, i + 1, n - i - 1))
                return i;            
                if (palindromMu(s, i, n - i - 2))
                return n - 1 - i;
                return -1;                
            }
        }
        return -1;    
    }
    
    private static bool palindromMu(string s, int start, int end)
    {
        while (start < end)
        {
            if (s[start] != s[end])
                return false;
            start++;
            end--;
        }
        return true;
    }
