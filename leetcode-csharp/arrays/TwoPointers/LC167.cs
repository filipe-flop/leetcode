using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetcode_csharp.arrays.TwoPointers
{
    public class LC167
    {
        // accepted
        // 0ms runtime
        // beats 100%
        public int[] TwoSum(int[] numbers, int target)
        {
            int start = 0;
            int end = numbers.Length - 1;

            while (start < end)
            {
                if (numbers[start] + numbers[end] == target)
                {
                    return new int[] { start + 1, end + 1 };
                }
                else if (numbers[start] + numbers[end] > target)
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }
            return null;
        }
    }
}
