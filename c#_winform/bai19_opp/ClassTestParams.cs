using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai19_opp
{
    internal class ClassTestParams
    {

        public ClassTestParams() { }

        public long sum(params int[] a)
        {
            int sum = 0;
            foreach(int x in a)
            {
                sum += x;
            }
            return sum;
        }
    }
}
