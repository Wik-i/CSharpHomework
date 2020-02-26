using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSecondClass
{
    class ArrayProblems
    {
        static void Main(string[] args)
        {
            //第二题
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4 ,3 ,2 ,1 };
            Console.Write("该数组的最大值为："+GetMax(array).ToString()+"\n");
            Console.Write("该数组的最小值为："+GetMin(array).ToString() + "\n");
            Console.Write("该数组的元素平均值为："+GetAverage(array).ToString() + "\n");
            Console.Write("该数组的最大值为："+GetSum(array).ToString() + "\n");
            Console.Write("\n");
        }

        public static int GetMax(int[]array)
        {
            int max = array[0];
            foreach (int element in array)
            {
                max = max < element ? element:max;
            }
            return max;
        }

        public static int GetMin(int[] array)
        {
            int min = array[0];
            foreach(int element in array)
            {
                min = min < element ? min : element;
            }
            return min;
        }

        public static int GetAverage(int[] array)
        {
            int sum = 0;
            int average = 0;
            foreach(int element in array)
            {
                sum += element;
            }
            average = sum / array.Length;
            return average;
        }

        public static int GetSum(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }
    }

  
}
