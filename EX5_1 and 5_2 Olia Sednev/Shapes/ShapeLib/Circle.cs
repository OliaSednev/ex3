using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Circle: Ellipse
    {
        public double radius { get; set; }
        public ConsoleColor color { get; set; }
        public Circle(ConsoleColor color, double radius) : base(color, radius, 0)
        {
            this.radius = radius;
        }
        public override void Display()
        {
            base.Display();
        }
        public override double Area { get { return Math.PI*(Math.Pow(radius,2)); } }
    }
}
