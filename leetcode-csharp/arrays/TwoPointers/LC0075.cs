using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.arrays.TwoPointers
{
    public class LC0075
    {
        // 75 - Sort Colors
        // accepted (after struggling and see hint)
        // runtime 0ms
        // beats 100%
        public void SortColors(int[] nums)
        {
            int i = 0;
            int left = 0;
            int right = nums.Length - 1;

            while (i <= right)
            {
                int l = nums[left];
                int r = nums[right];
                int i2 = nums[i];
                if (nums[i] == 0)
                {
                    if (i == left)
                    {
                        left++;
                        i++;
                    }
                    else
                    {
                        int temp = nums[left];
                        nums[left] = nums[i];
                        nums[i] = temp;
                        left++;
                    }
                }
                else if (nums[i] == 2)
                {
                    int temp = nums[i];
                    nums[i] = nums[right];
                    nums[right] = temp;
                    right--;
                }
                else
                {
                    i++;
                }             
            }
        }
    }
}
