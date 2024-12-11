using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.ArrayCode
{
    internal class MinSubArrayLenCase
    {
        public static int MinSubArrayLen(int target, int[] nums)
        {
            int left = 0;
            int right = 0;
            int minCount = int.MaxValue;
            int currentCount = 0;
            int sum = 0;
            while (right < nums.Length)
            {
                // right得值
                sum += nums[right++];
                currentCount++;
                // 判断sum是否达标
                if (sum >= target) {
                    
                    // 判断是否可以减区间
                    while (left <= right)
                    {
                        // 减去当前left值依旧大于target代表可以右移
                        if((sum - nums[left]) >= target)
                        {
                            sum -= nums[left];
                            left++;
                            currentCount--;
                        }
                        else
                        {
                            break;
                        }
                    }
                    // 减完区间后判断当前的区间总数是否小于最小区间总数
                    minCount = minCount > currentCount ? currentCount : minCount;
                }
                
            }
            return minCount == int.MaxValue ? 0:minCount;
        }
    }
}
