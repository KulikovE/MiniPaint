using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MiniPaint
{
    [Serializable]
    [XmlInclude(typeof(Rectangle))]
    abstract public class Figure
        //: IXmlSerializable
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

        Color color;

        float width;

        /// <summary>
        /// Ручка
        /// </summary>
       private Pen pen;    

        /// <summary>
        /// Свойство доступа к координате X
        /// </summary>
         public int X { get { return x; } set { x = value; } }

        /// <summary>
        /// Свойство доступа к координате Y
        /// </summary>
        public int Y { get { return y; } set { y = value; } }


        /// <summary>
        /// Свойство доступа к координате x правого нижнего угла прямоугльника
        /// </summary>
        public int X1 { get { return x1; } set { x1 = value; } }

        /// <summary>
        /// Свойство доступа к координате y правого нижнего угла прямоугольника
        /// </summary>
        public int Y1 { get { return y1; } set { y1 = value; } }

        /// <summary>
        /// Ручка, используемая для фигуры
        /// </summary>
        private Pen Pencil { get { return pen; } set { pen = value; } }


        /// <summary>
        /// Цвет
        /// </summary>
        public Color Color { get { return color; } set { color = color; } }
        //fdsfsdf
        public float Width { get { return width; } set { width = value; } }


        /// <summary>
        /// Конструктор фигуры
        /// </summary>
        /// <param name="x">Координата x</param>
        /// <param name="y">Координата y</param>
        /// <param name="x1">Вторая координата x</param>
        /// <param name="y1">Вторая координата y</param>
        /// <param name="pen">Ручка</param>
        public Figure(int x, int y, int x1, int y1, Pen pen)
        {
            X = x;
            Y = y;
            X1 = x1;
            Y1 = y1;
            Pencil = pen;
            Color = pen.Color;
            Width = pen.Width;
        }
        public Figure() { }


        /// <summary>
        /// Абстрактный метод рисования
        /// </summary>
        public abstract void Draw(Graphics gr);
    }
}
