using System;

namespace Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(3, 6, 9 );
            Point point2 = new Point(2, 4, 8);
           
            Cube cube1 = new Cube(point1, 10);
            Cube cube2 = new Cube(point2, 4);

            if (cube1.IsCollide(cube2))
                Console.WriteLine("Cube1 collides with Cube2.");
            else
                Console.WriteLine("Cube1 does not collide with Cube2.");
        }
    }
}
