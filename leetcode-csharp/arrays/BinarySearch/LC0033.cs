using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.arrays.BinarySearch
{
    public class LC0033
    {
        public int Search(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;

            if (r == 0)
            {
                if (nums[0] == target)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            
            while (l < r)
            {
                int mid = r - ((r - l) / 2);
                if (nums[mid] > nums[l] && nums[mid] > nums[r])
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            int pivot = l;
            if (nums[pivot] > target)
            {
                l = 0;
                r = pivot - 1;
            }
            else
            {
                l = pivot;
                r = nums.Length - 1;
            }

            while (l < r)
            {
                int mid = r - ((r - l) / 2);
                if (mid == r)
                {
                    if (nums[l] == target)
                    {
                        return l;
                    }
                    else if (nums[r] == target)
                    {
                        return r;
                    }
                    else
                    {
                        return -1;
                    }
                }
                if (nums[mid] >= target)
                {
                    r = mid;
                }
                else
                {
                    l = mid;
                }
            }
            return r;
        }
    }
}
