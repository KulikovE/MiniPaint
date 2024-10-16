using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MiniPaint
{
    [Serializable]
    [XmlInclude(typeof(GeometryObject))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(StraightLine))]
    [XmlInclude(typeof(Color))]
    [XmlInclude(typeof(Curve))]
    public abstract class GeometryObject
    {
        Color color;
        float width;
        /// <summary>
        /// Цвет
        /// </summary>
        [XmlIgnore]
        public Color Color { get { return color; } set { color = value; } }


        [XmlElement("Color")]
        public string ColorHtml
        {
            get { return ColorTranslator.ToHtml(Color); }
            set { Color = ColorTranslator.FromHtml(value); }
        }

        public float Width { get { return width; } set { width = value; } }

        public GeometryObject(Pen pen) { 
            Color = pen.Color;
            Width = pen.Width;
        }

        public GeometryObject() { }
        /// <summary>
        /// Абстрактный метод рисования
        /// </summary>
        public abstract void Draw(Graphics gr);

    }
}
