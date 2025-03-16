using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.arrays.HashMap
{
    public class LC001
    {
        //accepted
        //runtime 1ms
        //beats 98.14%
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (d.ContainsKey(complement)) {
                    return new int[] { d[complement], i };
                }
                d[nums[i]] = i;
            }
            return new int[] {};
        }
    }
}
