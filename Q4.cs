using System;

namespace lab_3
{
  class Q4
  {
    public Q4() 
    {
      string[] arr = new string[10];

      Console.Write("Input 10 names in the array :\n");
      for (int i = 0; i < 10; i++)
      {
          Console.Write("name-{0}: ", i);
          arr[i] = Console.ReadLine();
      }

      Console.Write("\nnames in array are: ");
      foreach (var name in arr)
      {
          Console.Write("\n{0}", name);
      }

      Console.ReadKey();
    }
  }
}