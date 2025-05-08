public static List<int> gradingStudents(List<int> grades)
{
  List<int> result = new List<int>();
  foreach (int grade in grades)
  {
    if (grade < 38)
    {
      result.Add(grade);
    }
    else
    {
      int nextMultipleOf5 = ((grade / 5) + 1) * 5;i
      if (nextMultipleOf5 - grade < 3)
      {
        result.Add(nextMultipleOf5);
      }
      else
      {
        result.Add(grade);
        }
      }
    }
  return result;
}
