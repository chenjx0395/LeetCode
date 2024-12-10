using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.ArrayCode
{
    internal class RemoveElementCase
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int length = nums.Length;
            int count = 0;
            int[] record = new int[length];
            int left = 0, right = length - 1;
            // 遍历数组
            for (int i = 0; i < length; i++)
            {
                if (nums[i] == val)
                {
                    record[left++] = i;
                    count++;
                }
                else
                {
                    record[right--] = i;
                }
            }
            left = 0;
            right = length - 1;
            // 每次交换应交换目标值索引数组的最小值
            // 交换元素
            for (int i = 0; i < length - count; i++)
            {
                int leftMinIndex = NumsMin(record, count);
                if (record[right] > record[leftMinIndex])
                {
                    nums[record[leftMinIndex]] = nums[record[right]];
                    record[leftMinIndex] = record[right];
                }
                right--;
            }
            return count;
        }

        // 找出数组最小值的索引
        private static int NumsMin(int[] nums, int length)
        {
            int minIndex = 0;
            for (int i = 1; i < length; i++)
            {
                if (nums[i] < nums[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }
    }
}
