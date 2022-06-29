using System;

namespace dotnet_hello_world {

    class ExceptionExample {
        private string name = "Bikash Shrestha";

        public string Name {
            get {
                return name;
            }
            set {
                if (value.Length > 10) {
                    throw new Exception("Name is too long");
                }
                name = value;
            }
        }

        public static void Main(String [] args) {
            // ExceptionExample obj = new ExceptionExample();
            // try{
            //     Console.Write("Enter you name: ");
            //     obj.Name = Console.ReadLine();
            // }catch (Exception e) {
            //     Console.WriteLine(e.Message);
            // }finally {
            //     Console.WriteLine("Hello, " + obj.Name);
            // }

            // divide by zero exception
            int a = 10, b = 0, rel = 0;
            
            try {
                rel = a / b;
            } catch (DivideByZeroException e) {
                Console.WriteLine(e.Message);
            } finally {
                Console.WriteLine("Result: {0}", rel);
            }

        }
    }
}