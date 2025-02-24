using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.arrays.TwoPointers
{
    public class LC015
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            int start = 1;
            int end = nums.Length - 1;
            IList<IList<int>> ret = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] + nums[start] + nums[end] == 0)
                {
                    ret.Add(new List<int> { nums[i], nums[start], nums[end] });
                }
                else
                {
                    if (nums[start] > nums[end])
                    {
                        start++;
                    }
                    else
                    {
                        end--;
                    }
                }
            }
            return [];
        }
    }
}
