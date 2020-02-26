using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSecondClass
{
    class PrimNum
    {
        static void Main(string[] args)
        {
            //第一题
            Console.Write(" 输入一个数字：" + "\n");
            string input = Console.ReadLine();
            int numIn = int.Parse(input);
            Console.Write(numIn+"的素数因子有：");
            GetPrimNum(numIn);
            Console.Write("\n");//停下以查看结果
            Console.Write("\n");
        }


         public static void GetPrimNum(int num)
        {
            int flag = 1;//控制是否输出
            if (num == 1)
            {
                return;
            }
            for(int i=2; i < num+1; i++)//遍历2到本身
            {
                flag = 1;
                if (num % i == 0)// 能整除
                {
                    for(int n = 2; n < i; n++)//检查是否是素数
                    {
                        if (i % n == 0) {flag=0; break; }
                    }
                    if (flag == 1)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }

  
}
