using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public abstract class Shape
    {
        public ConsoleColor Color { get; set; }
        public abstract double Area { get; }

        public Shape(ConsoleColor color)
        {
            Color = color;
        }
        public Shape() : this(ConsoleColor.White){}
        public virtual void Display()
        {
            Console.ForegroundColor = Color;

        }
    }
}
