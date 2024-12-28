using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HashTableCode
{
    public class IntersectionCase
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var dictionary = new Dictionary<int, int>();
            var dictionary2 = new Dictionary<int, int>();
            var result = new List<int>();
            // 将nums1中的元素加入字典
            foreach (var i in nums1)
            {
                if (dictionary.ContainsKey(i))
                {
                    continue;
                }
                dictionary.Add(i,1);
            }
            foreach (var i in nums2)
            {
                if (dictionary.ContainsKey(i))
                {
                    if (!dictionary2.ContainsKey(i))
                    {
                        dictionary2.Add(i,1);
                    }
                }
            }
            return dictionary2.Keys.ToArray();
        }
        public int[] Intersection2(int[] nums1, int[] nums2)
        {
            var hash1 = new bool[1001];
            var result = new int[1001];
            var count = 0;
            foreach (var i in nums1)
            {
                hash1[i] = true;
            }
            foreach (var i in nums2)
            {
                // 代表有相同的元素
                if (!hash1[i]) continue;
                result[count++] = i;
                hash1[i] = false;
            }
            return result.Take(count).ToArray();
        }
    }
}