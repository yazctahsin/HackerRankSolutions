 public static int diagonalDifference(List<List<int>> arr)
{
    int n = arr.Count;
    int primaryDiagonal = 0;
    int secondaryDiagonal = 0;

    for (int i = 0; i < n; i++)
    {
        primaryDiagonal += arr[i][i]; 
        secondaryDiagonal += arr[i][n - i - 1]; 
    }

    return Math.Abs(primaryDiagonal - secondaryDiagonal); 
}
