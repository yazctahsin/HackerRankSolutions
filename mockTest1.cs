public static int findMedian(List<int> arr)
{
  int boyut = arr.Count;
  arr.Sort();
  int median;
  if(boyut % 2 == 0)
  {
    median = arr[(boyut/2)-1] + arr[boyut/2];
  }
  else
  {
    median = arr[boyut/2];
  }
  return median;
}
