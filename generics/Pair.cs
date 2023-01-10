using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Pair<T1, T2>
    {
        public T1 Val1 { get; set; }
        public T2 Val2 { get; set; }

        public Pair(T1 V1, T2 V2)
        {
            Val1 = V1;
            Val2 = V2;
        }

        public void GetSumPairValues(Action<string> output)
        {
            output($"Sum: {Val1.ToString() + Val2.ToString()}");
        }

    }
}
