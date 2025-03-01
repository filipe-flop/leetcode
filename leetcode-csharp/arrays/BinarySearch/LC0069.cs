using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.arrays.BinarySearch
{
    public class LC0069
    {
        // accepted
        // runtime 0ms
        // beats 100%
        public int MySqrt(int x)
        {
            int l = 0;
            int r = x;
            int mid = 0;

            while (l <= r)
            {
                mid = r - ((r - l) / 2);
                if (mid == 0)
                    return 0;

                if (mid == r)
                {
                    if (x/mid >= mid)
                    {
                        return r;
                    }
                    else
                    {
                        return l;
                    }
                }
                if (x/mid == mid)
                {
                    return mid;
                }

                if (x/mid > mid)
                {
                    l = mid;
                }
                else
                {
                    r = mid;
                }
            }
            return mid;
        }
    }
}
