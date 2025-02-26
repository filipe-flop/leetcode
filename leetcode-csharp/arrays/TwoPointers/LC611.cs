using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.arrays.TwoPointers
{
    public class LC611
    {
        // accepted
        // 26ms
        // beats 98.46%
        public int TriangleNumber(int[] nums)
        {
            int ret = 0, left, right;

            if (nums.Length < 3)
                return ret;

            Array.Sort(nums); // O(n log n) time | O(log n) space

            for (int i = nums.Length - 1; i > 0; i--)
            {
                left = 0;
                right = i - 1;
                while (right > left)
                {
                    if (nums[left] + nums[right] > nums[i])
                    {
                        ret += right - left;
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }
            return ret;
        }
    }
}
