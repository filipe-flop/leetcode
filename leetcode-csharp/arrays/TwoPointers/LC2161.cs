using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.arrays.TwoPointers
{
    public class LC2161
    {
        // accepted
        // runtime 8ms
        // beats 38.46%
        // not using pointers
        // three passes - O(n) space - too bad!
        public int[] PivotArray(int[] nums, int pivot)
        {
            List<int> ret = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < pivot)
                {
                    ret.Add(nums[i]);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == pivot)
                {
                    ret.Add(nums[i]);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > pivot)
                {
                    ret.Add(nums[i]);
                }
            }
            int[] ret2 = ret.ToArray();
            return ret2;
        }

        // accepted
        // runtime 5ms
        // beats 84.62%
        // two passes - using pointers - not too bad!
        public int[] PivotArray2(int[] nums, int pivot)
        {
            int less = 0;
            int equal = 0;
            foreach (int num in nums)
            {
                if (num < pivot)
                {
                    less++;
                }
                else if (num == pivot)
                {
                    equal++;
                }
            }

            int lessI = 0;
            int equalI = less;
            int greaterI = less + equal;
            int[] ans = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < pivot)
                {
                    ans[lessI] = nums[i];
                    lessI++;
                }
                else if (nums[i] == pivot)
                {
                    ans[equalI] = nums[i];
                    equalI++;
                }
                else
                {
                    ans[greaterI] = nums[i];
                    greaterI++;
                }
            }
            return ans;
        }

        // accepted
        // runtime 3ms
        // beats 100%
        // single pass - using pointers - very good!
        public int[] PivotArray3(int[] nums, int pivot)
        {
            int lessI = 0;
            int greaterI = nums.Length - 1;
            int[] ans = new int[nums.Length];

            for (int i = 0, j = nums.Length - 1; i < nums.Length; i++, j--)
            {
                if (nums[i] < pivot)
                {
                    ans[lessI] = nums[i];
                    lessI++;
                }
                if (nums[j] > pivot)
                {
                    ans[greaterI] = nums[j];
                    greaterI--;
                }
            }
            while (lessI <= greaterI)
            {
                ans[lessI] = pivot;
                lessI++;
            }
            return ans;
        }
    }
}
