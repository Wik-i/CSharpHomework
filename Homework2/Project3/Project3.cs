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
            //第三题
            Console.Write("使用埃氏筛法找1-100以内的素数：");
            GetPrim100();
            Console.ReadLine();
            Console.ReadLine();
        }

        public static void GetPrim100()
        {//使用埃氏筛法找100以内的素数
            int[] array= new int[101];
            array[0] = 1;array[1] = 1;//显然1不是素数
            for(int i = 2; i < 10; i++)
            {
                for(int j = 2; j * i < 101; j++)
                {
                    array[i * j] = 1;//标记 不是素数
                }
            }
            for(int i =0; i < 101; i++)//输出
            {
                if (array[i] == 0)
                {
                    Console.Write(i.ToString()+" ");
                }
            }
        }
    }
}
