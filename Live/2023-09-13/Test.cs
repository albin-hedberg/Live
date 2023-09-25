using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live
{
    internal class Test
    {
        public static void CounterClassDemo(CounterClass counter)
        {
            counter.CountUp();
        }
        public static void CounterRecordDemo(CounterRecord counter)
        {
            counter.CountUp();
        }
        public static void CounterStructDemo(ref CounterStruct counter)
        {
            counter.CountUp();
        }
    }
}
