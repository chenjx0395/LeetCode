using System.Collections.Generic;

namespace HashTableCode
{
    public class TwoSumCase
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, List<int>>();
            // 存入字典
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (dictionary.TryGetValue(num, out var old))
                {
                    old.Add(i);
                }
                else
                {
                    old = new List<int>(1) { i };
                    dictionary.Add(num, old);
                }
            }

            // 从字典中找匹配值
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                var value = target - num;
                // 判断数组中是否存在两个同样的数之和等于目标值的情况
                if (value == num)
                {
                    if (!dictionary.TryGetValue(value, out var count)) continue;
                    if (count.Count >= 2)
                    {
                        // 代表目标值和当前值相等，且数组中存在2个及以上
                        return new[] { count[0], count[1] };
                    }
                }
                else
                {
                    if (!dictionary.TryGetValue(value, out var count)) continue;
                    return new[] { i, count[0] };
                }
            }

            return null;
        }

        public int[] TwoSum2(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var difference = target-nums[i];
                if (dictionary.TryGetValue(difference, out var value))
                    return new[] { i, value };
                dictionary[nums[i]] = i;
            }
            return null;
        }
    }
}