using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.arrays.BinarySearch
{
    public class LC0035
    {
        public int SearchInsert(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            int mid = 0;

            while (l <= r)
            {
                mid = (l + r) / 2;
                if (l == r)
                {
                    return mid;
                }

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    r = mid;
                }
                else
                {
                    l = mid+1;
                }
            }
            return mid;
        }
    }
}
