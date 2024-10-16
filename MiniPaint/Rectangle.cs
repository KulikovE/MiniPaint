namespace MiniPaint
{
    [Serializable]
    public class Rectangle : Figure
    {
        /// <summary>
        /// Конструктор для прямоугольника
        /// </summary>
        /// <param name="x">Координата x левого верхнего угла прямоугольника</param>
        /// <param name="y">Координата y левого верхнего угла прямоугольника</param>
        /// <param name="x1">Координата x правого нижнего угла прямоугольника</param>
        /// <param name="y1">Координата y правого нижнего угла прямоугольника</param>
        /// <param name="pen">Ручка для прямоугольника</param>
        public Rectangle(int x, int y, int x1, int y1, Pen pen) : base(x, y, x1, y1, pen)
        {
        }

        public Rectangle()
        {
        }
        public override void Draw(Graphics gr)
        {
            int sx = X1 - X;
            int sy = Y1 - Y;

            gr.DrawRectangle(new Pen(Color, Width), Math.Min(X, X1), Math.Min(Y, Y1), Math.Abs(sx), Math.Abs(sy));
        }

    }
}
