using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.amazon.avaliations.avaliation01
{
    public class Av01Question2
    {
        // didn't pass
        public static long getMaxThroughput(List<int> host_throughput)
        {
            int n = host_throughput.Count;
            if (n < 3)
                return 0;

            host_throughput.Sort((a, b) => b.CompareTo(a));

            long systemThroughput = 0;

            for (int i = 1; i + 1 < n; i += 3)
            {
                systemThroughput += host_throughput[i];
            }

            return systemThroughput;
        }
    }
}
