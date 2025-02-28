using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.arrays.TwoPointers
{
    public class LC0016
    {
        // 16 3Sum Closest
        // accepted (after struggling and see solution)
        // runtime 13ms
        // beats 82.89%
        public int ThreeSumClosest(int[] nums, int target)
        {
            int ret = 0;
            int closestSum = int.MaxValue;
            int sum, left, right;

            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                left = i + 1;
                right = nums.Length - 1;

                while (left < right)
                {
                    sum = nums[i] + nums[left] + nums[right];

                    if (sum == target)
                    {
                        return sum;
                    }

                    if (Math.Abs(target - sum) < Math.Abs(target - closestSum))
                    {
                        closestSum = sum;
                        ret = sum;
                    }

                    if (sum < target)
                    {
                        left++;
                    }
                    else right--;
                }
                
            }

            return ret;
        }
    }
}
