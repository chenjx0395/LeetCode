using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.ArrayCode
{
    internal class SortedSquaresCase
    {
        public static int[] SortedSquares(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int[] resultNums = new int[nums.Length];
            int index = nums.Length - 1;
            while (left <= right)
            {
                if (nums[left] * nums[left] <= nums[right] * nums[right])
                {
                    resultNums[index--] = nums[right] * nums[right];
                    right--;
                }
                else
                {
                    resultNums[index--] = nums[left] * nums[left];
                    left++;
                }
            }
            return resultNums;
        }
    }
}
