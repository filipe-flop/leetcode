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
                        l = i+1;
                        r = i+1;
                    }
                }
                else
                {
                    r++;
                }
            }
            return new string(ret);
        }
    }
}
