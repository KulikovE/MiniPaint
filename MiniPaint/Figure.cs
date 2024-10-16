using System.Xml;
using System.Xml.Serialization;

namespace MiniPaint
{
    abstract public class Figure : GeometryObject
    {
        /// <summary>
        /// Координата x фигуры
        /// </summary>
        int x;
        /// <summary>
        /// Координата y фигуры
        /// </summary>
        int y;


        /// <summary>
        /// Вторая координата x фигуры
        /// </summary>
        int x1;
        /// <summary>
        /// Вторая координата y фигуры
        /// </summary>
        int y1;

       

        /// <summary>
        /// Свойство доступа к координате X
        /// </summary>
        public int X { get { return x; } set { x = value; } }

        /// <summary>
        /// Свойство доступа к координате Y
        /// </summary>
        public int Y { get { return y; } set { y = value; } }


        /// <summary>
        /// Свойство доступа к координате x правого нижнего угла прямоугольника
        /// </summary>
        public int X1 { get { return x1; } set { x1 = value; } }

        /// <summary>
        /// Свойство доступа к координате y правого нижнего угла прямоугольника
        /// </summary>
        public int Y1 { get { return y1; } set { y1 = value; } }

       

        


        /// <summary>
        /// Конструктор фигуры
        /// </summary>
        /// <param name="x">Координата x</param>
        /// <param name="y">Координата y</param>
        /// <param name="x1">Вторая координата x</param>
        /// <param name="y1">Вторая координата y</param>
        /// <param name="pen">Ручка</param>
        public Figure(int x, int y, int x1, int y1, Pen pen) : base(pen)
        {
            X = x;
            Y = y;
            X1 = x1;
            Y1 = y1;
        }
        public Figure() { }
    }
}
