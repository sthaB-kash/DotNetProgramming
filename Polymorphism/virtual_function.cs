using System;

namespace polymorphism_example {
    class Shape {
        protected double height, width;

        public Shape(double h, double w) {
            height = h;
            width = w;
        }

        public virtual double area() {
            Console.WriteLine("Parent class area: ");
            return 0;
        }
    }

    class Rectangle : Shape {
        public Rectangle(double h, double w) : base(h, w) {
        }

        public override double area() {
            Console.WriteLine("Rectangle class area: ");
            return height * width;
        }
    }

    class Triangle : Shape {
        public Triangle(double h, double w) : base(h, w) {
        }

        public override double area() {
            Console.WriteLine("Triangle class area: ");
            return (height * width) / 2;
        }
    }
}