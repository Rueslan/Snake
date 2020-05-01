using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '#');
            p1.Draw();
            Point p2 = new Point(4, 5, '*');
            p2.Draw();

            Console.ReadKey();
        }

        public static void Move(Point p, int dx, int dy)
        {
            p.x += dx;
            p.y += dy;
        }
        public static void Reset(Point p)
        {
            p = new Point();
        }

    }
}
