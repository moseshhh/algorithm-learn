using System;

class LinearSearch
{
  public static int search(int num, int[] arr)
  {
    int arrLength = arr.Length;
    int i;
    for (i = 0; i < arrLength; i++)
    {
      if (arr[i] == num)
      {
        return i;
      }
    }
    return -1;
  }

  public static void Main()
  {
    int[] arr = { 3, 4, 5, 1, 7, 9 };
    int searchNum = 9;

    int result = search(searchNum, arr);

    Console.WriteLine(result);
  }
}