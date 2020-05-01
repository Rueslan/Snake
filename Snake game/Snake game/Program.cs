using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            //VerticalLine vl = new VerticalLine(0, 10, 5, '%');
            //HorizontalLine hl = new HorizontalLine(0, 5, 6,'&');

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake)fSnake;

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTale())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    snake.Draw();
                } else
                    snake.Move();

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            PrintToCenter("Разработчик: Руслан К. г.Сарапул\r");

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

        static void Draw(Figure figure)
        {
            figure.Draw();
        }
        static void PrintToCenter(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(Console.WindowWidth / 2 - msg.Length / 2, Console.WindowHeight / 2);
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
