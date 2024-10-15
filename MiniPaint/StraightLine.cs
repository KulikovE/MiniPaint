using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MiniPaint
{
    public class StraightLine : Figure
    {
        /// <summary>
        /// Конструктор для прямой линии
        /// </summary>
        /// <param name="x">Координата x начала линии</param>
        /// <param name="y">Координата y начала линии</param>
        /// <param name="x1">Координата x конца линии</param>
        /// <param name="y1">Координата y конца  линии</param>
        /// <param name="pen">Ручка для прямоугольника</param>
        public StraightLine(int x, int y, int x1, int y1, Pen pen) : base(x, y, x1, y1, pen)
        {
        }

        public StraightLine() { }

        /// <summary>
        /// Переопределенный метод рисования
        /// </summary>
        /// <param name="gr">Графика</param>
        public override void Draw(Graphics gr)
        {
            gr.DrawLine(new Pen(Color, Width), X, Y, X1, Y1);
        }
    }
}
