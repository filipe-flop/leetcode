using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.amazon.avaliations.avaliation01
{
    //passed
    public class Av01Question1
    {
        public static long getMinimumValue(List<int> power, int armor)
        {
            long totalDamage = 0;
            long maxDamage = 0;

            for (int i = 0; i < power.Count; i++)
            {
                totalDamage += power[i];
                maxDamage = power[i] > maxDamage ? power[i] : maxDamage;
            }

            long armor2 = armor < maxDamage ? armor : maxDamage;
            long health = totalDamage - armor2 + 1;

            return health;
        }
    }
}
