//Write a program in c# to display a list of items in array using for(each). Use placeholder to display the content.
using System;
namespace Lab_2
{
  class Q2
  {
    public void display()
    {
      int[] arr = { 1, 2, 3, 4, 5 };
      Console.WriteLine("list of item in array:");
      int index = 0;
      foreach(int num in arr)
      {
        Console.WriteLine("array item at index [{0}]:> {1}", index++, num);
      }
      Console.ReadKey();
    }
  }
}