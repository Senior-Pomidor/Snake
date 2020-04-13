using System.Collections.Generic;

namespace Snake
{
    public class Figure
    {
        List<Point> plist;
        
        public void Draw()
        {
            foreach(Point p in plist)
            {
                p.Draw();
            }
        }
    }
}