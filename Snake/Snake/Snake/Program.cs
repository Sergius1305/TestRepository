using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);

            Point p1 = new Point(2, 3, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Draw();

            HorizontalLine uphLine = new HorizontalLine(0, Console.WindowWidth - 2, 0, '+');
            HorizontalLine dwnhLine = new HorizontalLine(0, Console.WindowWidth - 2, Console.WindowHeight - 1, '+');
            VerticalLine leftVLine = new VerticalLine(0, Console.WindowHeight - 1, 0, '+');
            VerticalLine rightVLine = new VerticalLine(0, Console.WindowHeight - 1, Console.WindowWidth - 2, '+');
            uphLine.Draw();
            dwnhLine.Draw();
            leftVLine.Draw();
            rightVLine.Draw();

            FoodCreator foodCreator = new FoodCreator(Console.WindowWidth, Console.WindowHeight, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key);
                }

                Thread.Sleep(100);
                
            }
        }
    }
}
