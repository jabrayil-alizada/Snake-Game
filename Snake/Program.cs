using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 4;
            p1.sym = 'X';

            p1.Draw();

            Point p2 = new Point();
            p2.x = 3;
            p2.y = 5;
            p2.sym = '#';

            p2.Draw();

            Console.ReadLine();
        }
    }
}
