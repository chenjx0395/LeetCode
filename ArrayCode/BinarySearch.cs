using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCode
{
    internal class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            //左闭右开思路    
            int lP = 0;
            int rP = nums.Length;
            int middle;
            while (lP < rP)
            {
                middle = (lP + rP) / 2;
                if (target == nums[middle])
                {
                    return middle;
                }
                else if (target > nums[middle])
                {
                    lP = middle + 1;
                }
                else
                {
                    rP = middle;
                }
            }
            return -1;
        }
    }
}
