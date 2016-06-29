using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Ellipse: Shape, IPersist, IComparable
    {
        public double radius1 { get; set; }
        public double radius2 { get; set; }
        public Ellipse(ConsoleColor color, double radius1, double radius2)
            : base(color)
        {
            this.radius1 = radius1;
            this.radius2 = radius2;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("First radius: {0}\nSecond radius: {1}", radius1, radius2);
        }

        public void Write(StringBuilder sb)
        {
            string temp = Convert.ToString(radius1);
            sb.AppendLine(temp);
            temp = Convert.ToString(radius2);
            sb.AppendLine(temp);
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            Ellipse otherEllipse = obj as Ellipse;
            if (otherEllipse != null)
            {
                if (obj.GetType() == otherEllipse.GetType())
                    return 0;
                return (radius1.CompareTo(otherEllipse.radius1));
            }
                
            else
                return 10;
        }

        public override double Area
        {
            get { return Math.PI*(radius1*radius2); }
        }
    }
}
