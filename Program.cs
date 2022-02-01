using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program lab2 = new Program();
            int option = 0;
            do{
                System.Console.Clear();
                Console.WriteLine("Lab-2");
                lab2.show_menu(lab2.get_all_questions());
                Console.Write("Enter your choice:>");
                string input = Console.ReadLine();
                int.TryParse(input, out option);
                switch(option){
                    case 1:
                        new Q1().say_hello_wrold();
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 7: Console.WriteLine("Thank you.."); break;
                    default: Console.WriteLine("Please select a valid option"); break;
                }
            }while(option!=7);
            // Q1 obj = new Q1();
            // obj.greeting();
        }

        private string[] get_all_questions(){
            string[] questions = {
                "Demonstration of structure and components of a basic c# program by hello world application.",
                "Write a program in c# to display a list of items in array using for(each). Use placeholder to display the content.",
                "Write a program in c# to take a user input and display its factorial using iterative method.",
                "Write a program in c# to take a user input and display its factorial using recursive method.",
                "Write a program in c# to take a user string and display its reverse using string method.",
                "Write a program in C# to take a user string and display its reverse without using string method."
            };
            return questions;
        }
         
        private void show_menu(string[] questions){
            for(int n=0; n<questions.Length; n++){
                Console.WriteLine("{0}. {1}", n+1, questions[n]);
            }
            Console.WriteLine("{0}. Exit", questions.Length);
        }
    }
}
