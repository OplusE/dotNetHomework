using System;

namespace classhomework1
{
    public abstract class Shape
    {
        public int width;
        public int hight;
        public double area;
        public void SetLine(int w,int h)
        {
            width = w;
            hight = h;
        }

        public int Outarea()
        {
            return this.width * this.hight;
        }
    }
    class Rec:Shape
    {
        public int Ar()
        {
            return (width*hight);
        }

    }
    class Squa:Shape
    {  

        public int Ar()
        {
            if (width == hight)
            {
                return(width*hight);
            }
            else
            {
                return  (0);
            }
        }
    }
    class Tra:Shape
    {
        public int line1, line2,line3;
        public void SetLine(int l1,int l2,int l3)
        {
            line1 = l1;
            line2 = l2;
            line3 = l3;
        }
        
        public double Chd()
        {
            if (line1 + line2 < line3 || line1 + line3 < line2 || line2 + line3 < line1)
            {
                return 0;
            }
            int p = (line1 + line2 + line3) / 2;
            int area2;
            area2 = p * (p - line1) * (p - line2) * (p-line3);
            this.area = Math.Sqrt(area2);
            return this.area;
        }
    }
    public class Factory
    {
        public static Shape Coutarea(string type)
        {
            Shape shape = null;
            switch (type)
            {
                case "Rec":
                    shape = new Rec();
                    break;
                case "Squa":
                    shape = new Squa();
                    break;
                case "tra":
                    shape = new Tra();
                    break;



            }
            return shape;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rec a = new Rec();
            Squa b = new Squa();
            Tra c = new Tra();
            a.SetLine(2, 3);
            b.SetLine(4, 4);
            c.SetLine(3, 4, 5);
            if (a.Ar() == 0)
            {
                Console.WriteLine("错误输入");
            }
            else
            {
                Console.WriteLine(a.Ar());
            }
            if (b.Ar() == 0)
            {
                Console.WriteLine("错误输入");
            }
            else
            {
                Console.WriteLine(b.Ar());
            }
            if (c.Chd() == 0)
            {
                Console.WriteLine("错误输入");
            }
            else
            {
                Console.WriteLine(c.Chd());
            }
            Shape shape;
            shape = Factory.Coutarea("Squa");
            shape.SetLine(4, 4);
            Console.WriteLine(shape.Outarea());
        }
    }
}
