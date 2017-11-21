using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class OldRectangle
    {
        private int x, y, w, h;

        public OldRectangle(int x, int y, int w, int h)
        {
            this.x = x; this.y = y; this.w = w; this.h = h;
        }
        public void DisplayArea()
        {
            int area = w * h;
            Console.WriteLine("My area is " + area);
        }
    }

    public interface CalculateArea
    {
        void CalculateArea();
    }

    public class NewRectangle : CalculateArea
    {
        private OldRectangle oldRect;

        public NewRectangle(int x1, int y1, int x2, int y2)
        {
            oldRect = new OldRectangle(x1, y1, x2 - x1, y2 - y1);
        }

        public NewRectangle(OldRectangle oldRect)
        {
            this.oldRect = oldRect;
        }
        public void CalculateArea()
        {
            oldRect.DisplayArea();
        }
    }
}
