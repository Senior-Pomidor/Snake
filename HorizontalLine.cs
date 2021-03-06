using System.Collections.Generic;

namespace Snake
{
    public class HorizontalLine : Figure
    // HorizontalLine наследуется от класса Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();

            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}