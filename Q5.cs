// Write a program in c# to take a user string and display its reverse using string method.

using System;
namespace Lab_2 
{
  class Q5
  {
    public Q5()
    {
      reverseString();
    }

    private void reverseString() 
    {
      Console.Write("enter a string:> ");
      string str = Console.ReadLine();
      
      char[] strArray = str.ToCharArray();
      Array.Reverse(strArray);
      Console.WriteLine("using built-in method: {0}", new string(strArray));
      Console.ReadKey();
    }
  }
}