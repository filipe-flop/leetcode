using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.arrays.TwoPointers
{
    public class LC0011
    {
        // 11 Max Area
        // accepted
        // 1ms runtime
        // beats 99.91%
        public int MaxArea(int[] height)
        {
            int start = 0;
            int end = height.Length - 1;
            int maxArea = 0;

            while (start < end)
            {
                int y = height[start] < height[end] ? height[start] : height[end];
                int x = end - start;
                if (x * y > maxArea)
                {
                    maxArea = x * y;
                }
                if (height[start] < height[end])
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            return maxArea;
        }
    }
}
