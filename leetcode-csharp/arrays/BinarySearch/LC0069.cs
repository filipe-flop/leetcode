using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.arrays.BinarySearch
{
    public class LC0069
    {
        public int MySqrt(int x)
        {
            int l = 0;
            int r = x;
            int mid = 0;

            while (l <= r)
            {
                mid = (l + r) / 2;
                if (mid * mid == x)
                {
                    return mid;
                }

                if (mid * mid > x)
                {
                    r = mid;
                }
                else
                {
                    l = mid;
                }
            }
            return mid;
        }
    }
}
