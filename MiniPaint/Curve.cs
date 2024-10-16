namespace MiniPaint
{
    [Serializable]
    public abstract class Curve : GeometryObject
    {
        /// <summary>
        /// Лист всех точек данной кривой (получен в промежутке между MoseDown и MouseUp)
        /// </summary>
        List<SerializablePoint> points;


        /// <summary>
        /// Доступ к листу точек данной кривой (получен в промежутке между MoseDown и MouseUp)
        /// </summary>
        public List<SerializablePoint> Points {  get { return points; } set { points = value; } }

        public Curve(List<SerializablePoint>points, Pen pen) : base(pen) 
        {
            Points = points;
        }
        public Curve() { }
    }
}
