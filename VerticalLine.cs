using System.Collections.Generic;

namespace Snake
{
    public class VerticalLine
    {
        List<Point> plist;

        public VerticalLine(int yTop, int yBottom, int x, char sym)
        {
            plist = new List<Point>();

            for(int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }

        public void Draw()
        {
            foreach(Point p in plist)
            {
                p.Draw();
            }
        }
    }
}