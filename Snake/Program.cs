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
            //Create square
            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            topLine.Drow();
            bottomLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p1 = new Point(3, 4, 'X');
            Snake snake = new Snake(p1, 5, Direction.DOWN);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
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

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }


            /*snake.Drow();
            snake.Move();


           /while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.handleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

    */

            //Console.ReadLine();
        }
    }
}
