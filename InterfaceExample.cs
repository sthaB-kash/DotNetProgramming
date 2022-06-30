using System;

namespace interface_example {
    public interface Drawable {
        void draw();
    }

    public class Circle: Drawable {
        public void draw() {
            Console.WriteLine("Draw Circle");
        }
    }

    public class Rectangle: Drawable {
        public void draw() {
            Console.WriteLine("Draw Rect.");
        }
    }

    class Test {
        // public static void Main(String[] args) {
        //     Drawable d;
        //     d = new Rectangle();
        //     d.draw();
        //     d = new Circle();
        //     d.draw();

        //     new Rectangle().draw();
        //     new Circle().draw();
        // }
    }
}