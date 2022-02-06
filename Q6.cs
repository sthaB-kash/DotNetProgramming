// Write a program in c# to take a user string and display its reverse without using string method.

using System;
namespace Lab_2 
{
  class Q6
  {
    public Q6()
    {
      reverseString();
    }

    private void reverseString() 
    {
      Console.Write("enter a string:> ");
      string str = Console.ReadLine();
      
      char[] strArray = str.ToCharArray();
      Console.Write("\nReversed: ");
      for(int i=strArray.Length-1; i>=0; i--){
        Console.Write("{0}", strArray[i]);
      }
      Console.ReadKey();
    }
  }
}