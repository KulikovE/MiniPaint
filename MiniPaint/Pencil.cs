using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint
{
    public class Pencil : Curve
    {
        public Pencil(List<SerializablePoint> points, Pen pen) : base (points, pen) {;}
        public Pencil() { }

        public override void Draw(Graphics gr)
        {
            gr.DrawLine(new Pen(Color, Width), X, Y, X1, Y1);
        }
    }
}
