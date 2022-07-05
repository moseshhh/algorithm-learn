using System;

class BinarySearch
{
  public static int search(int[] arr, int x, int lowIndex, int highIndex)
  {
    int mid = (highIndex + lowIndex) / 2;

    if (lowIndex < highIndex)
    {
      if (arr[mid] < x)
      {
        return search(arr, x, mid, highIndex);
      }
      if (arr[mid] > x)
      {
        return search(arr, x, lowIndex, mid);
      }
      if (mid == x)
      {
        return mid;
      }
    }
    else
    {
      return -1;
    }
  }
  public static void Main()
  {
    int[] arrayNum = { 1, 2, 3, 4, 5 };
    int pos = search(arrayNum, 4, 0, 4);
    Console.WriteLine(pos);
  }
}