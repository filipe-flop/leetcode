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
                int remainder = target - nums[i];
                if (d.ContainsKey(remainder)) {
                    return new int[] { d[remainder], i };
                }
                d[nums[i]] = i;
            }
            return new int[] {};
        }
    }
}
