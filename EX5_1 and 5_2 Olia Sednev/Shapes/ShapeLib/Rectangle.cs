using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Rectangle: Shape, IPersist, IComparable
    {
        public double width { get; set; }
        public double height { get; set; }
        public Rectangle(ConsoleColor color, double width, double height)
            : base(color)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area { get { return (2 * (width + height)); } }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Width: {0}\nHeight: {1}", width, height);
        }

        public void Write(StringBuilder sb)
        {
            string temp = Convert.ToString(width);
            sb.AppendLine(temp);
            temp = Convert.ToString(height);
            sb.AppendLine(temp);
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            Rectangle otherRectangle = obj as Rectangle;
            if(otherRectangle != null)
            {
                if (this.GetType() == otherRectangle.GetType())
                    return 0;
                return (width.CompareTo(otherRectangle.width));

            }
            else
                return 10;
        }
    }
}
