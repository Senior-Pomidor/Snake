using System;

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
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 2;
            p1.sym = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();

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

