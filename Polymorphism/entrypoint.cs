using System;

namespace polymorphism_example {
    class Program {
        static void Main() {
            // method overloading
            // PrintData p = new PrintData();
            // p.print(10);
            // p.print(10.5f);
            // p.print(10.5);
            // p.print("Hello World");
            // p.print('A');

            //  OPERATOR OVERLOADING
            Box b1 = new Box(10, 20, 30);
            Box b2 = new Box(20, 30, 40);
            b1.printVolume();
            b2.printVolume();
            Box b3 = b1 + b2;
            b3.printVolume();   
        }
    }
}