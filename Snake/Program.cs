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
            /*Point p1 = new Point(1, 4, 'X');
            p1.Draw();

            Point p2 = new Point(3, 5, '#');
            p2.Draw();*/

            int x = 1;
            Func1(x);
            Console.WriteLine("Call Func1.x = " + x);

            x = 1;
            Func2(x);
            Console.WriteLine("Call Func2.x = " + x);

            x = 1;
            Func3(x);
            Console.WriteLine("Call Func3.x = " + x);

            Point p1 = new Point(1, 3, 'L');
            Move(p1, 3, 7);
            Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y);

            Point p2 = new Point(2, 5, '#');
            Point p3 = new Point(2, 5, '#');
            p1 = p2 = p3;

            p2.x = 8;
            p2.y = 8;
            Console.WriteLine("p1 = p2. p1.x = " + p1.x + " p1.y = " + p1.y + ", p2.x = " + p2.x + ", p2.y = " + p2.y + ", p3.x = " + p3.x + ", p3.y = " + p3.y);

            p1 = new Point(1, 2, '*');
            Console.WriteLine("Call update. p1.x = " + p1.x + " p1.y = " + p1.y + ", p2.x = " + p2.x + ", p2.y = " + p2.y);

            Console.ReadLine();
        }
        public static void Func1(int value)
        {

        }
        public static void Func2(int value)
        {
            value++;
        }
        public static void Func3(int x)
        {
            x++;
        }
        public static void Move(Point p, int dx, int dy)
        {
            p.x = dx;
            p.y = dy;
        }
    }
}
