using ShapeLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp
{
    public class ShapeManager
    {
        // Stas allows to use list<> instead ArrayList
        public List<Shape> list;

        public Shape this[int index] { get { return list[index]; } }
        public int Count { get { return list.Count; } }
        public ShapeManager()
        {
            list = new List<Shape>();
        }
        public void Add(Shape shape)
        {
            list.Add(shape);
        }
        public void DisplayAll()
        {
            foreach (Shape s in list)
            {
                s.Display();
                Console.WriteLine("The area is:  {0}\n", s.Area);
            }
        }

        //I could not understand why the circle also enters the StringBuilder :(
        public void Save(StringBuilder sb)
        {
            foreach (Shape s in list)
            {
                if(s is IPersist)
                {
                    ((IPersist)s).Write(sb);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            ShapeManager M_shape = new ShapeManager();
            Shape r1 = new Rectangle(ConsoleColor.Blue, 7, 8);
            Rectangle r2 = new Rectangle(ConsoleColor.DarkRed, 6, 9);
            Shape e1 = new Ellipse(ConsoleColor.Green, 5, 6);
            Ellipse e2 = new Ellipse(ConsoleColor.DarkYellow, 1, 4);
            Shape c1 = new Circle(ConsoleColor.Magenta, 5);
            Circle c2 = new Circle(ConsoleColor.Yellow, 8);

            //Add Method
            M_shape.Add(r1); 
            M_shape.Add(r2);
            M_shape.Add(e1);
            M_shape.Add(e2);
            M_shape.Add(c1);
            M_shape.Add(c2);

            Console.WriteLine("DisplayAll test:");
            Console.WriteLine("------------------");
            M_shape.DisplayAll();

            Console.WriteLine("Indexer tests:");
            Console.WriteLine("---------------"); 
            Console.WriteLine(M_shape[1]);
            Console.WriteLine(M_shape[3]);
            Console.WriteLine(M_shape[5]);
            Console.WriteLine("\n\n");

            //StringBuilder
            StringBuilder sb = new StringBuilder();
            
            M_shape.Save(sb);
            Console.WriteLine("IPersist");
            Console.WriteLine("----------");
            Console.WriteLine(sb.ToString());
            Console.WriteLine();


            Console.WriteLine("IComperable Tests:");
            Console.WriteLine("------------------");
            Ellipse e_1 = new Ellipse(ConsoleColor.DarkYellow, 8, 0);
            Ellipse e_2 = new Ellipse(ConsoleColor.DarkYellow, 5, 0);
            Shape c_1 = new Circle(ConsoleColor.Magenta, 8);
            Circle c_2 = new Circle(ConsoleColor.Yellow, 8);
            Shape r_1 = new Rectangle(ConsoleColor.Blue, 7, 8);
            Rectangle r_2 = new Rectangle(ConsoleColor.DarkRed, 6, 9);

            //1
            Console.WriteLine("Ellipse and Ellipse");
            int result = e_1.CompareTo(e_2);
            if (result == 0)
            {
                Console.WriteLine("The same kind of shape!!!\n");
            }
            else if (result == -1)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }
            else if (result == 1)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }
            else if (result == 10)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }

            //2
            Console.WriteLine("Ellipse and Rectangle");
            result = e_2.CompareTo(r_1);
            if (result == 0)
            {
                Console.WriteLine("The same kind of shape!!!\n");
            }
            else if (result == -1)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }
            else if (result == 1)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }
            else if (result == 10)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }

            //3
            Console.WriteLine("Rectangle and Ellipse");
            result = r_2.CompareTo(e_2);
            if (result == 0)
            {
                Console.WriteLine("The same kind of shape!!!\n");
            }
            else if (result == -1)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }
            else if (result == 1)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }
            else if (result == 10)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }
            //4
            Console.WriteLine("Rectangle and Rectangle");
            result = r_2.CompareTo(r_1);
            if (result == 0)
            {
                Console.WriteLine("The same kind of shape!!!\n");
            }
            else if (result == -1)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }
            else if (result == 1)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }
            else if (result == 10)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }

            //5
            Console.WriteLine("Rectangle and Circle");
            result = r_2.CompareTo(c_1);
            if (result == 0)
            {
                Console.WriteLine("The same kind of shape!!!\n");
            }
            else if (result == -1)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }
            else if (result == 1)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }
            else if (result == 10)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }

            //6
            Console.WriteLine("Ellipse and Circle");
            result = e_2.CompareTo(c_1);
            if (result == 0)
            {
                Console.WriteLine("The same kind of shape!!!\n");
            }
            else if (result == -1)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }
            else if (result == 1)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }
            else if (result == 10)
            {
                Console.WriteLine("Not the same kind of shape!!!\n");
            }


        }
    }
}
