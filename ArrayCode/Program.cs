using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayCode;
using LeetCodeCSharp.ArrayCode;

namespace ArrayCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            //3. 最小长度子数组
            // Case3();
            //2.删除元素
            // Case02();
            // 1.二分查找
            //Case01();
            //螺旋矩阵2
            Case4();
        }

        public static void Case4()
        {
            var a =  GenerateMatrixCase.GenerateMatrix(3);
            foreach (var i in a)
            {
                foreach (var i1 in i)
                {
                    Console.Write(i1+"  ");
                }
                Console.WriteLine();
            }
        }

        public static void Case3()
        {
            int[] nums = { 2, 3, 1, 2, 4, 3 };
            int target = 7;
            MinSubArrayLenCase.MinSubArrayLen(target, nums);
        }



        public static void Case02()
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int value = 2;
            RemoveElementCase.RemoveElement1(nums, value);
        }




        public static void Case01()
        {
            int[] arr01 = { -1, 0, 3, 5, 9, 12 };
            int target = 9;
            int result = BinarySearch.Search(arr01, target);
            Console.WriteLine(result);
        }
    }
}
