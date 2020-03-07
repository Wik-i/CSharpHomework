using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the length of edge of your Square:");
            double edge = Double.Parse(Console.ReadLine());
            Square mySquare = new Square(edge);
            Console.WriteLine("\n" + "the area of your square is :");
            Console.WriteLine(mySquare.GetArea());
            //快速测试其他图形
            Triangle myTriangle = new Triangle(edge, edge, edge);
            Console.WriteLine(myTriangle.GetArea());
            Rectangle myRectangle = new Rectangle(edge, edge);
            Console.WriteLine(myRectangle.GetArea());


            Console.ReadLine();
            Console.ReadLine();
        }
    }
    interface Shape
    {
        double GetArea();
        bool IsLegal();

    }

    class Square:Shape
    {
        protected double edge;
        public double Edge { get => edge; set => edge = value; }
        public Square(double edge)
        {
            if (edge < 0) { Console.WriteLine("The edge of Square is invalid"); return; }
            this.edge = edge;
        }

        public bool IsLegal()
        {
            return edge > 0;
        }

        public double GetArea()
        {//因为赋值时检测了非法输入，计算面积时无需重复
            return edge*edge;
        }
    }

    class Rectangle : Shape
    {
        protected double length, width;
        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }
        public Rectangle(double length, double width)
        {
            if (length < 0 || width < 0) { Console.WriteLine("The edge of Rectangle is invalid"); return; }
            this.length = length;
            this.width = width;
        }
        public bool IsLegal()
        {
            return length > 0 && width > 0;
        }
        public double GetArea()
        {//因为赋值时检测了非法输入，计算面积时无需重复
            return length * width;
        }
    }

    class Triangle : Shape
    {
        protected double firstLength, secondLength, thirdLength;
        public double FirstLengh { get => firstLength; set => firstLength = value; }
        public double SecondLengh { get => secondLength; set => secondLength = value; }
        public double ThirdLengh { get => ThirdLengh; set => thirdLength = value; }
        public Triangle(double firLen, double secLen, double thrLen)
        {
            if (firLen < 0 || secLen < 0 || thrLen < 0) { Console.WriteLine("The edge of Triangle is invalid"); return; }
            this.firstLength = firLen;
            this.secondLength = secLen;
            this.thirdLength = thrLen;
        }
        public bool IsLegal()
        {
            if (firstLength + secondLength > thirdLength && firstLength + thirdLength > secondLength && secondLength + thirdLength > firstLength)
            {
                return true;
            }
            return false;
        }
        public double GetArea()
        {
            if (!IsLegal()) { Console.WriteLine("The Triangle is invalid"); return 0; }//边长合法可是不一定能构成三角形 需要二次检验
            double p = (firstLength + secondLength + thirdLength)/2;// 三角形边长和
            return Math.Sqrt(p * (p - firstLength) * (p - secondLength) * (p - thirdLength));//海伦公式
        }
    }
}
