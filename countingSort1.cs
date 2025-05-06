public static List<int> countingSort(List<int> arr)
{
    List<int> count = new List<int>(new int[100]); // 0'dan 99'a kadar sayılar için boş liste oluştur

    foreach (int num in arr)
    {
        count[num]++;
    }

    return count;
}
