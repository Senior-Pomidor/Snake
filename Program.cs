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

            Console.SetBufferSize(120, 30);


            // отрисовка рамки
            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            topLine.Draw();
            bottomLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
            
            // запись с конструктором
            // отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            // класс лист
            // List<int> numList = new List<int>();
            // numList.Add(0);
            // numList.Add(1);
            // numList.Add(2);

            // foreach (int i in numList)
            // {
            //     Console.WriteLine(i);
            // }

            // numList.RemoveAt(0); //удаляет элемент с индексом 0
            // // Console.WriteLine(numList[0]);

            // List<Point> plist = new List<Point>();
            // plist.Add(p1);
            // plist.Add(p2);

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

