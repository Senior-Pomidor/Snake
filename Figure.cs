using System.Collections.Generic;

namespace Snake
{
    public class Figure
    {
        protected List<Point> plist;
        
        public void Draw()
        {
            foreach(Point p in plist)
            {
                p.Draw();
            }
        }
    }
}