using System;

namespace geometric_shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Square()
            {
                Side1 = 5
            };
            Console.WriteLine($"Perimeter is {s1.Perimeter()}");
            Console.WriteLine($"Perimeter is {s1.Perimeter()}");

            var r1 = new Rect()
            {
                Side1 = 3,
                Side2 = 5
            };
            Console.WriteLine($"Perimeter is {r1.Perimeter()}");
            Console.WriteLine($"Area is {r1.Perimeter()}");

            var q1 = new Quad()
            {
                Side1 = 3, Side2 = 4, Side3= 5, Side4 = 6
            };
            Console.WriteLine($"Perimeter is {q1.Perimeter()}");

        }
    }
}
