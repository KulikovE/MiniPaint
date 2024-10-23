using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint
{
    public class SerializablePoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public SerializablePoint() { }

        public SerializablePoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public SerializablePoint(Point point)
        {
            X = point.X;
            Y = point.Y;
        }

        public Point ToPoint()
        {
            return new Point(X, Y);
        }
    }
}