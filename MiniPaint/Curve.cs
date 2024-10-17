namespace MiniPaint
{
    [Serializable]
    public class Curve : Figure
    {
        public Curve(int x, int y, int x1, int y1, Pen pen) : base(x, y, x1, y1, pen) { }
        public Curve() { }


        public override void Draw(Graphics gr)
        {
            gr.DrawLine(new Pen(Color, Width), new Point(X, Y), new Point(X1, Y1));
        }



    }
}
