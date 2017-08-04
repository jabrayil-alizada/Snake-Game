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
            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            Draw(v1);

            Point p = new Point(4, 5, '*');
            Figure fsnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fsnake);
            Snake snake = (Snake)fsnake;

            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fsnake);
            figures.Add(v1);
            figures.Add(h1);

            foreach(var f in figures)
            {
                f.Drow();
            }

            Console.ReadLine();
        }

        static void Draw(Figure figure)
        {
            figure.Drow();
        }
    }
}
