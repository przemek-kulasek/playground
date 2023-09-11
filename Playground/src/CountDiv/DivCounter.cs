using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDiv
{
    public static class DivCounter
    {
        public static int Count(int A, int B, int K)
        {
            var count = (B / K) - (A / K);

            if (A % K == 0)
            {
                count++;
            }

            return count;
        }
    }
}
