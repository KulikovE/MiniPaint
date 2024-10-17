namespace MiniPaint
{
    [Serializable]
    public class Curve : Figure
    {
        List<SerializablePoint> points = new List<SerializablePoint>();

        public List<SerializablePoint> Points {  get { return points; } set { points = value; } }
        public Curve(int x, int y, int x1, int y1, Pen pen, List<SerializablePoint> points) : base(x, y, x1, y1, pen) {
            Points = points;
        }
        public Curve() { }


        public override void Draw(Graphics gr)
        {
            for (int i = 1; i < points.Count; i++)
            {
                gr.DrawLine(new Pen(Color, Width), points[i-1].ToPoint(), points[i].ToPoint());
            }
            
        }



    }
}
