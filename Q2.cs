using System;
using System.Text;

namespace lab_3
{
  class Q2 
  {
    public Q2() 
    {
      StringBuilder strB = new StringBuilder();
      strB.Append("Hello I'm Bikash Shrestha");
      Boolean substring = strB.ToString().Contains("Hello");
      Console.WriteLine(substring);
      char c = strB[3];
      char[] arr = new char[10];
      Console.WriteLine("Appended string:" + strB);
      strB.CopyTo(2, arr, 2, 4);
      Console.WriteLine("Copied string:");
      Console.Write(arr);
      Console.ReadLine();
    }
  }
}