using System;

namespace lab_3
{
  class Q1
  {
    public void getInteger()
    {
      int val = 0;
      Console.Write("enter an integer: ");
      string input = Console.ReadLine();
      int.TryParse(input, out val);
      object obj = val;
      unboxing(obj);
    }
    private void unboxing(Object obj)
    {
      Console.WriteLine("unboxed param. is: {0}", (int)obj);
    }
  }
}