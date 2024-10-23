namespace MiniPaint
{
    [Serializable]
    public class Rubber : Figure
    {
        List<SerializablePoint> points = new List<SerializablePoint>();

        public List<SerializablePoint> Points { get { return points; } set { points = value; } }
        public Rubber(int x, int y, int x1, int y1, Pen pen, List<SerializablePoint> points) : base(x, y, x1, y1, pen)
        {
            Points = points;
        }
        public Rubber() { }


        public override void Draw(Graphics gr)
        {
            for (int i = 1; i < points.Count; i++)
            {
                gr.DrawLine(new Pen(Color.White, Width), points[i - 1].ToPoint(), points[i].ToPoint());
            }

        }

    }
}
