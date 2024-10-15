using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MiniPaint
{
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        double radius;

        /// <summary>
        /// Конструктор для круга
        /// </summary>
        /// <param name="x">Координата x центра круга</param>
        /// <param name="y">Координата y центра круга</param>
        /// <param name="x1">Вторая координата x, которая находится на расстоянии радиуса от центра круга</param>
        /// <param name="y1">Вторая координата y, которая находится на расстоянии радиуса от центра круга</param>
        /// <param name="pen">Ручка, используемая для круга</param>
        public Circle(int x, int y, int x1, int y1, Pen pen) : base(x, y, x1, y1, pen)
        {
            Radius = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2));

        }

        public Circle() { }

        /// <summary>
        /// Свойство доступа к радиусу круга
        /// </summary>
        public double Radius { get { return radius; } set { radius = value; } }

        public override void Draw(Graphics gr)
        {
            //   gr.DrawEllipse(Pencil, (float)(X - Radius), (float)(Y - Radius), (float)(Radius * 2), (float)(Radius * 2));
            gr.DrawEllipse(new Pen(Color, Width), (float)(X - Radius), (float)(Y - Radius), (float)(Radius * 2), (float)(Radius * 2));
        }
    }
}
