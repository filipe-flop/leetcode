using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.arrays
{
    public class LC557
    {
        public string ReverseWords(string s)
        {
            int l = 0;
            int r = 0;
            char[] ret = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString().Equals(" ") || i == s.Length - 1)
                {
                    while (l != r)
                    {
                        ret[l] = s[r - 1];
                        l++;
                        r--;
                    }
                    ret[l] = s[r - 1];
                    l = i;
                    r = i;
                }
                else
                {
                    r++;
                }
            }
            return s;
        }
    }
}
