using System;

namespace polymorphism_example {
    class Box {
        private double length, breadth, height;
        
        public Box(double l, double b, double h) {
            length = l;
            breadth = b;
            height = h;
        }
        
        private double getVolume() {
            return length * breadth * height;
        }
        
        public void printVolume() {
            Console.WriteLine("Volume is: {0}", getVolume());
        }

        public static Box operator +(Box a, Box b) {
            Box box = new Box(a.length + b.length, a.breadth + b.breadth, a.height + b.height);
            return box;
        }
    }
}