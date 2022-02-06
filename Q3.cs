// Write a program in c# to take a user input and display its factorial using iterative method.

using System;
namespace Lab_2
{
  class Q3
  {
    public Q3()
    {
      display_factorial();
    }

    private void display_factorial()
    {
     Console.Write("Enter a number: ");
            string val = Console.ReadLine();
            int num = 1;
            int.TryParse(val, out num);
            int fact = 1;
            for( int i = num; i!=1; i--){
              fact*= i;
            } 
            Console.WriteLine("The factorial of {0} is {1}", val, fact);
            Console.ReadKey();
    }
  }
}