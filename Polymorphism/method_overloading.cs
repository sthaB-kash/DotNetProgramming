using System;

namespace polymorphism_example {
    class PrintData {
        public void print(int i) {
            Console.WriteLine("Integer: {0}", i);
        }

        public void print(float f) {
            Console.WriteLine("Float: {0}", f);
        }

        public void print (double d) {
            Console.WriteLine("Double: {0}", d);
        }

        public void print(string s) {
            Console.WriteLine("String: {0}", s);
        }  

        public void print(char c) {
            Console.WriteLine("Char: {0}", c);
        }
    }
}