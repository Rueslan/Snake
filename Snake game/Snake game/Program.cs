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
            Point p2 = new Point(2, 7, '#');
            p1.Draw();
            Reset(p1);
            List<Point> numList = new List<Point>();
            numList.Add(p1);
            numList.Add(p2);
            foreach(Point i in numList)
            {
                i.Draw();
            }

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
