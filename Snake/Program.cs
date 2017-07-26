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
            Point p1 = new Point(1, 4, 'X');
            p1.Draw();

            Point p2 = new Point(3, 5, '#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            List<char> charList = new List<char>();
            charList.Add('U');
            charList.Add('L');
            charList.Add('K');

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (char i in charList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);

        
       
            Console.ReadLine();
        }
    }
}
