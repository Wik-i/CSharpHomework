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
            Shape []ProList = Factory.MakeRandomProduct(10);//制造10个随机图形
            double area = Factory.GetArea(ProList);//计算总面积
            Console.WriteLine("The area of the ten random shapes is:" + area);
            Console.ReadLine();
            Console.ReadLine();
        }
    }

    class Factory
    {
        public static Shape MakeProduct(string kind,double[] length,int firstPos)
        {//length数组存放生产相应形状的必要长度数据，从length[firstPos]开始作为第一个数据
            Shape product = null;
            switch (kind)
            {
                case "Square":product = new Square(length[firstPos]); break;
                case "Triangle":product = new Triangle(length[firstPos],length[firstPos+1],length[firstPos+2]); break;
                case "Rectangle":product = new Rectangle(length[firstPos], length[firstPos+1]); break;
                case "Circle":product = new Circle(length[firstPos]); break;
                default:Console.WriteLine("Sorry! The factory can't produce this kind of product!"); break;
            }
            return product;
        }
        public static Shape[] MakeRandomProduct(int num) {
            Shape []ProductList=new Shape[num];
            Random ran = new Random();
            Dictionary<int, string> ranProList = new Dictionary<int, string>();//生成一个随机数对应产品的字典
            ranProList.Add(1, "Square");
            ranProList.Add(2, "Triangle");
            ranProList.Add(3, "Rectangle");
            ranProList.Add(4, "Circle");
            double[] ranLenList=new double[10*num];
            for(int i = 0; i < 10 * num; i++)
            {//生成随机边长数组
                ranLenList [i] = ran.Next(1, 20);
            }
            for(int i = 0; i < num;i++ )
            {//生成随机形状 
                ProductList[i] = MakeProduct(ranProList[ran.Next(1, 5)],ranLenList,10*i);
            }
            return ProductList;
        }

        public static double GetArea(Shape[]ProductList)
        {
            double area = 0;
            int numOfPro = 0;
            foreach(Shape Product in ProductList)
            {
                area = Product.GetArea();
                numOfPro++;
            }
            return area/numOfPro;
        }
    }

    abstract class Shape
    {
        public abstract bool IsLegal();
        public abstract double GetArea();
    }

    class Square : Shape
    {
        protected double edge;
        public double Edge { get => edge; set => edge = value; }
        public string name;
        public string Name { get => name; }
        public Square(double edge)
        {
            if (edge<0) { Console.WriteLine("The edge of Square is invalid");return; }
            this.edge = edge; this.name = "Square";
        }
        public override bool IsLegal()
        {
            return edge > 0;
        }
        public override double GetArea()
        {
            return edge * edge;
        }
    }

    class Rectangle : Shape
    {
        protected double length, width;
        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }
        public string name;
        public string Name { get => name; }

        public Rectangle(double length,double width)
        {
            if (length<0||width<0) { Console.WriteLine("The edge of Rectangle is invalid"); return; }
            this.length = length;
            this.width = width;
            this.name = "Rectangle";
        }
        public override bool IsLegal()
        {
            return length>0&&width>0;
        }
        public override double GetArea()
        {
            return length*width;
        }
    }

    class Circle : Shape
    {
        protected double radius;
        public double Radius { get => radius; set => radius = value; }
        protected double Pi;
        public string name;
        public string Name { get => name; }

        public Circle(double radius)
        {
            if (radius<0) {Console.WriteLine("The radius is invalid"); return; }
            this.radius = radius;
            Pi = 3.1415926535;
            this.name = "Circle";
        }
        public override bool IsLegal()
        {
            return radius>0;
        }
        public override double GetArea()
        {
            return Pi *radius*radius;
        }

    }
    class Triangle : Shape
    {
        protected double firEdge, secEdge, thrEdge;
        public double FirEdge { get => firEdge; set => firEdge = value; }
        public double SecEdge { get => secEdge; set => secEdge = value; }
        public double ThrEdge { get => thrEdge; set => thrEdge = value; }
        public string name;
        public string Name { get => name; }

        public Triangle(double firEdge,double secEdge, double thrEdge)
        {//保证赋值正确
            if (firEdge<0||secEdge<0||thrEdge<0) { Console.WriteLine("The edge of Triangle is invalid"); return; }
            this.firEdge = firEdge;
            this.secEdge = secEdge;
            this.thrEdge = thrEdge;
            this.name = "Triangle";
        }
        public override bool IsLegal()
        {
            if ((firEdge + secEdge > thrEdge) && (firEdge + thrEdge > secEdge) && (secEdge + thrEdge > firEdge))
            { return true; }
            return false;
        }
        public override double GetArea()
        {
            if (!IsLegal()) { Console.WriteLine("The Triangle is invalid"); return 0; }//边长合法可是不一定能构成三角形 需要二次检验
            double p =( firEdge + secEdge + thrEdge)/2;
            return Math.Sqrt(p*(p-firEdge)*(p-secEdge)*(p-thrEdge));
        }

    }
}
