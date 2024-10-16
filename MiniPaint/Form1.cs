using System.Xml.Serialization;

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        delegate void Draw();
        Draw draw;
        Pen pen = new Pen(Color.Black, 1);
        List<Point> points = new List<Point>();
        List<GeometryObject> geoObjectss = new();
        bool drawing = false;
        bool clickPoint = false;
        private bool mousedown = false;
        private bool drawingCurve = false;
        private Point firstPoint;
        private Point secondPoint;
        List<SerializablePoint> pointsSerial;

        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SbrosFlags();
            draw = DrawStraight;
        }

        private void SbrosFlags()
        {
            if (clickPoint)
            {
                Refresh();
                clickPoint = false;
            }
            points.Clear();
            drawing = true;
            drawingCurve = false;
        }

        private void DrawStraight()
        {
            Graphics g = CreateGraphics();
            StraightLine st = new(points[0].X, points[0].Y, points[1].X, points[1].Y, pen);
            geoObjectss.Add(st);
            st.Draw(g);
        }

        private void DrawRectangle()
        {
            Graphics g = CreateGraphics();
            Rectangle rc = new(points[0].X, points[0].Y, points[1].X, points[1].Y, pen);
            geoObjectss.Add(rc);
            rc.Draw(g);
        }

        private void DrawCircle()
        {
            Graphics g = CreateGraphics();
            Circle circle = new Circle(points[0].X, points[0].Y, points[1].X, points[1].Y, pen);
            geoObjectss.Add(circle);
            circle.Draw(g);
        }

        private void DrawCurve()
        {
            Graphics g = CreateGraphics();
            //Curve curve = new Curve(firstPoint.X, firstPoint.Y, secondPoint.X, secondPoint.Y, pen);
            geoObjectss.Add(curve);
            curve.Draw(g);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Point p = new Point(e.X, e.Y);
                points.Add(p);

                if (points.Count == 2)
                {
                    draw();
                    SbrosFlags();
                }
                if (points.Count == 1)
                {
                    clickPoint = true;
                    Graphics graphics = CreateGraphics();
                    graphics.DrawEllipse(new Pen(pen.Color, 1), e.X, e.Y, 1, 1);
                }
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingCurve)
            {
                if (mousedown)
                {
                    secondPoint = firstPoint;
                    firstPoint = e.Location;
                    using (Graphics g = this.CreateGraphics())
                    {
                        draw();
                    }
                }
            }
            label1.Text = e.X.ToString() + " " + e.Y.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SbrosFlags();
            draw = DrawRectangle;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SbrosFlags();
            draw = DrawCircle;

        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            foreach (GeometryObject f in geoObjectss)
            {
                Graphics g = CreateGraphics();
                f.Draw(g);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pen = new Pen(dlg.Color, pen.Width);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen = new Pen(pen.Color, comboBox1.SelectedIndex + 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (geoObjectss.Count > 0)
            {
                geoObjectss.RemoveAt(geoObjectss.Count - 1);
                Refresh();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XmlSerializer XMLListformatter = new XmlSerializer(typeof(List<GeometryObject>));
            using (FileStream fs = new FileStream("geoObjectssList.xml", FileMode.Create))
            {
                XMLListformatter.Serialize(fs, geoObjectss);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            geoObjectss.Clear();
            XmlSerializer XMLListformatter = new XmlSerializer(typeof(List<GeometryObject>));
            using (FileStream fs = new FileStream("geoObjectssList.xml", FileMode.Open))
            {
                geoObjectss = (List<GeometryObject>)XMLListformatter.Deserialize(fs);
            }
            Refresh();
        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mousedown = true;
            firstPoint = e.Location;
            pointsSerial.Add(new SerializablePoint(firstPoint));
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            draw = DrawCurve;
            drawing = false;
            drawingCurve = true;
            Pencil pencil = new Pencil();
        }
    }
}
