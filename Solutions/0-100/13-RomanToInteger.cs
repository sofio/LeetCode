using System.Collections.Generic;

namespace Solutions._0_100
{
    public class _13_RomanToInteger
    {
        public int RomanToInt(string s)
        {
            var map = new Dictionary<char, int>()
            {
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000}
            };

            var lastIndex = s.Length - 1;
            var integerToReturn = map[s[lastIndex]];
            if (s.Length >= 2)
            {
                for (int i = lastIndex; i >= 1; i--)
                {
                    if (map[s[i - 1]] >= map[s[i]])
                    {
                        integerToReturn += map[s[i-1]];
                    }
                    else
                    {
                        integerToReturn -= map[s[i-1]];
                    }

                }

            }
            return integerToReturn;
        }
    }
}
