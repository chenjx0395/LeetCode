using System.Collections.Generic;
using System.Linq;

namespace HashTableCode
{
    public class IsHappyCase
    {
        public static bool IsHappy(int n)
        {
            var hash = new HashSet<int>();
            while (n != 1 && hash.Add(n))
            {
                var ints = new List<int>();
                // 先取模10的余数，在除10
                while (n != 0)
                {
                    ints.Add(n % 10);
                    n /= 10;
                }
                foreach (var i in ints)
                {
                    n += i * i;
                }
            }
            return n == 1;
        }
    }
}