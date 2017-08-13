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
        public const int initialSnakesLength = 4;

        static void Main(string[] args)
        {
            //Console.SetBufferSize(81, 26);

            Walls walls = new Walls(80, 25);
            walls.Drow();

            //Drowing points
            Point p = new Point(2, 5, '*');
            Snake snake = new Snake(p, initialSnakesLength, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food)){
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

            WriteGameOver(snake);
            Console.ReadLine();
        }

        static void WriteGameOver(Snake snake)
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("G A M E    O V E R", xOffset + 5, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("Your score: " + (snake.score - initialSnakesLength), xOffset + 2, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("Author: Jabrayil Alizada", xOffset + 2, yOffset++);
            WriteText("============================", xOffset, yOffset++);
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

    }
}
