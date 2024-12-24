using System.Collections.Generic;

namespace HashTableCode
{
    public class IsAnagramCase
    {
        public bool IsAnagram(string s, string t)
        {
            var sChars = s.ToCharArray();
            var tChars = t.ToCharArray();
            if (sChars.Length != tChars.Length)
                return false;
            var dictionary = new Dictionary<char, int>();
            
            foreach (var tChar in tChars)
            {
                dictionary.TryGetValue(tChar, out var value);
                dictionary[tChar] = value + 1;
            }
            foreach (var sChar in sChars)
            {
                dictionary.TryGetValue(sChar, out var value);
                if (value == 0)
                {
                    return false;
                }
                dictionary[sChar] = value - 1;
            }
            return true;
        }
    }
}