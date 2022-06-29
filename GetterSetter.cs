using System;

namespace dotnet_hello_world {

    class GetterSetterExample {
        private string name = "Bikash Shrestha";

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }


        
    }

    // class ExampleTest {
    //     public static void Main(String[] args) {
    //         GetterSetterExample obj = new GetterSetterExample();
    //         Console.WriteLine(obj.Name);
    //         obj.Name = Console.ReadLine();
    //         Console.WriteLine(obj.Name);
    //     }
    // }
}