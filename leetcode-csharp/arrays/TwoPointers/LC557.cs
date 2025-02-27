using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.arrays.TwoPointers
{
    public class LC557
    {
        // 557 Reverse Words
        // accepted
        // 8ms runtime
        // beats 36.11%
        public string ReverseWords(string s)
        {
            int l = 0;
            int r = 0;
            char[] ret = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString().Equals(" ") || i == s.Length - 1)
                {
                    if (i == s.Length - 1)
                        r++;
                    while (r > l)
                    {
                        ret[l] = s[r - 1];
                        ret[r - 1] = s[l];
                        l++;
                        r--;
                    }
                    if (s[i].ToString().Equals(" "))
                    {
                        ret[i] = ' ';
                        l = i + 1;
                        r = i + 1;
                    }
                }
                else
                {
                    r++;
                }
            }
            return new string(ret);
        }

        public string Solution(string s)
        {
            char[] chars = s.ToCharArray();
            int start = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ' || i == chars.Length - 1)
                {
                    int end = i == chars.Length - 1 && chars[i] != ' ' ? i + 1 : i;
                    while (start < end)
                    {
                        char temp = chars[start];
                        chars[start] = chars[end - 1];
                        chars[end - 1] = temp;
                        start++;
                        end--;
                    }
                    start = i + 1;
                }
            }

            return new string(chars);
        }
    }
}
