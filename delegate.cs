using System;
// using System.Delegate;

namespace delegate_example {
    // public delegate void MyDelegate();
    // public class DelegateExample {
    //     public static void Main(String[] args) {
    //         MyDelegate d = new MyDelegate(DelegateExample.Print);
    //         d();
    //     }
    //     public static void Print() {
    //         Console.WriteLine("Hello World!");
    //     }
    // }


    public delegate string MyDelegate(string s);

    public class DelegateExample {
        public event MyDelegate MyEvent;

        public DelegateExample() {
            MyEvent += new MyDelegate(WelcomeUser);
        }

        public string WelcomeUser(string s) {
            return "Welcome " + s;
        }

        public static void Main(String[] args) {
            DelegateExample obj = new DelegateExample();
            Console.WriteLine(obj.MyEvent("Bikash"));
        }
    }
}