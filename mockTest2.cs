class Result
{
/*
* Complete the 'flippingMatrix' function below.
*
* The function is expected to return an INTEGER.
* The function accepts 2D_INTEGER_ARRAY matrix as parameter.
*/
public static int flippingMatrix(List<List<int>> matrix)
{
  int result = 0;
  int boyut = matrix.Count();
  int maxValue = 0;
  for(int i = 0 ; i < boyut /2 ; i++)
  {
    for(int j = 0 ; j < boyut /2 ; j++)
    {
      maxValue = matrix[i][j];
      if(matrix[i][boyut - j -1] > maxValue)
      {
        maxValue = matrix[i][boyut - j -1];
      }
      if(matrix[boyut-i-1][j] > maxValue)
      {
        maxValue = matrix[boyut - i -1][j];
      }
      if(matrix[boyut - i -1][boyut - j -1] > maxValue)
      {
        maxValue = matrix[boyut - i -1][boyut - j -1];
      }
      result += maxValue;
    }
  }
  return result;
}
