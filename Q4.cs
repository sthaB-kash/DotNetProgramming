// Write a program in c# to take a user input and display its factorial using recursive method.

using System;

namespace Lab_2
{
  class Q4
  {
    public Q4()
    {
      Console.Write("Enter a number: ");
      string val = Console.ReadLine();
      int num = 1;
      int.TryParse(val, out num);
      Console.WriteLine("factorial of {0} using recursive method:> {1}", num, fact(num));
      Console.ReadKey();
    }

    private int fact(int num) 
    {
      if(num <= 1)
        return 1;
      else
        return num* fact(num-1);
    }
  }
}