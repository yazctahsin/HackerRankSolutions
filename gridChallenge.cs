public static string gridChallenge(List<string> grid)
    {
        
        for (int i = 0; i < grid.Count; i++)
        {
            char[] rowArray = grid[i].ToCharArray();
            Array.Sort(rowArray);  
            grid[i] = new string(rowArray);
        }

        
        for (int col = 0; col < grid[0].Length; col++)
        {
            for (int row = 1; row < grid.Count; row++)
            {
                if (grid[row][col] < grid[row - 1][col])
                {
                    return "NO";
                }
            }
        }

        return "YES"; 
    }
