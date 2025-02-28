using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.arrays.TwoPointers
{
    public class LC0283
    {
        // accepted
        // runtime 1ms
        // beats 96.69%
        public void MoveZeroes(int[] nums)
        {
            int lastNonZero = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[lastNonZero];
                    nums[lastNonZero] = nums[i];
                    nums[i] = temp;
                    lastNonZero++;
                }
            }
        }
    }
}
