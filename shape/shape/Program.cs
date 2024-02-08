using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    abstract class Shape
    {
        protected string name;
        public string Name { get { return name; } }
        public Shape(string name)
        {
            this.name = name;
        }
       public abstract double getArea();
    
    }
    class Circle : Shape
    {
        double a;
        public double A
        {
            set { a = value; }
            get { return a; }
        }
        public Circle(string name,double a) : base(name) 
        { 
            this.a = a;
        }
        public override double getArea()
        {
            return 2 * 3.14 * a;
        }
    }

    class Rectangle : Shape
    {
        double a;
        double b;
        public double A
        {
            set { a = value; }
            get { return a; }
        }

        public double B
        {
            set { b = value; }
            get { return b; }
        }
        public Rectangle(string name,double a,double b):base(name) 
        {
            this.a = a;
            this.b = b;
        }
        public override double getArea()
        {
            return a*b;
        }
        public static bool operator == (Rectangle r1, Rectangle r2)
        {
            return r1.a==r2.a&&r1.b==r2.b;
        }
        public static bool operator !=(Rectangle r1, Rectangle r2)
        {
            return r1.getArea()!=r2.getArea();
        }
    }
     class MyUtils
    {
        public List<Shape> maxAreas(List<Shape> shapes)
        {
            List<Shape> list = new List<Shape>();
            List<Rectangle> maximums = new List<Rectangle>();
          
            //Rectangle a = shapes[2] as Rectangle;
            double s_c = 0;
            double s_r = 0;
            Circle tmp=new Circle("",0);
            Rectangle tmp_r = new Rectangle("", 0, 0);
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i] is Circle)
                {
                    Circle c = (Circle)shapes[i];
                    if (s_c < c.getArea())
                    {
                        s_c = c.getArea();
                        tmp = c;
                    }
                }
                else if(shapes[i] is Rectangle)
                {
                    Rectangle r = (Rectangle)shapes[i];
                    if (s_r < r.getArea())
                    {
                        s_r = r.getArea();
                        tmp_r = r;
                    }
                }
            }
            if(s_r!=0)
            {
                for(int i=0; i < shapes.Count; i++)
                {
                    if (shapes[i] is Rectangle)
                    {
                        Rectangle r = (Rectangle)shapes[i];
                        if (s_r == r.getArea())
                        {
                            maximums.Add(r);
                        }
                    }
                }
                int count = 0;
                for(int i=0;i<maximums.Count; i++)
                {
                    for(int j=0;j<maximums.Count;j++)
                    {
                        if (maximums[i] == maximums[j])
                        {
                            count++;
                           
                        }
                    }
                    if(count >1)
                    {
                        maximums.RemoveAt(i);
                        i = 0;
                        
                    }
                    count = 0;
                }
                
                for(int i=0;i<maximums.Count;i++)
                {
                    list.Add(maximums[i]);
                }
            }

            if (s_c != 0)
                list.Add(tmp);
            return list;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List < Shape> a = new List<Shape>();
            MyUtils myUtils = new MyUtils();
            a.Add(new Circle("Circle", 2.00));
            a.Add(new Rectangle("Rectangle", 2.00, 3.00));
            a.Add(new Circle("Circle", 1.00));
            a.Add(new Rectangle("Rectangle", 3.00, 2.00));
            a.Add(new Circle("Circle", 0.50));
            a.Add(new Circle("Circle", 0.50));
            a.Add(new Rectangle("Rectangle", 1.00, 2.00));
            a.Add(new Rectangle("Rectangle", 1.00, 2.00));
            List<Shape> b = myUtils.maxAreas(a);
            for(int i=0;i<b.Count;i++)
            {
                if (b[i] is Circle)
                {
                    Circle c = (Circle)b[i];
                    Console.WriteLine(c.Name + " " + c.A);
                }
                else if (b[i] is Rectangle)
                {
                    Rectangle r = (Rectangle)b[i];
                   Console.WriteLine(r.Name + " " + r.A+" "+r.B);
                }
            }
            Console.ReadKey();
        }
    }
}
