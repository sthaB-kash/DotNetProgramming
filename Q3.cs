using System;

namespace lab_3
{
  class Q3
  {
    public Q3() 
    {
      int[] arr = { 20, 45, 99, 34, 78, 89, 34, 77, 95 };
      foreach (var elm in arr)
      {
          Console.Write(elm + " ");
      }
      Array.Sort(arr);
      Array.Reverse(arr);
      Console.WriteLine("\nSecond Largest element in array is: " + arr[1]);

      Console.ReadLine();
    }
  }
}