using System;

namespace geometric_shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Square(5);
            s1.Print();

            var s2 = new Square(5);
            s2.Print();

            var r1 = new Rect(3, 5);
            r1.Print();
            
            var r2 = new Rect(3, 7);
            r2.Print();
           
            var q1 = new Quad(3, 4, 5, 6);
            q1.Print();
        }
    }
}
