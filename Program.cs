using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
        // процедурный подход
            // int x1 = 1;
            // int y1 = 3;
            // char sym1 = '*';

            // Draw(x1, y1, sym1);

        // подход ООП
            // запись без конструктора
            // Point p1 = new Point();
            // p1.x = 1;
            // p1.y = 2;
            // p1.sym = '*';
            // p1.Draw();

            // запись с конструктором
            Point p1 = new Point(1, 2, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0); //удаляет элемент с индексом 0
            // Console.WriteLine(numList[0]);

            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);

            Console.ReadLine();
        }
        // процедурный подход
        // для ООП этот метод определён в классе Point
        // static void Draw(int x, int y, char sym)
        // {
        //     Console.SetCursorPosition(x, y);
        //     Console.Write(sym);
        // }
    }
}

