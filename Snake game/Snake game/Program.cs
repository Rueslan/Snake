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
            Move(p2, 10, 10);
            p2.Draw();
            Console.ReadKey();
            Reset(p2);
            Console.WriteLine($"{p2.x}{p2.y}{p2.sym}");
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
            p.x = 0;
            p.y = 0;
            p.sym = '\0';
        }

    }
}
