using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live
{
    internal record CounterRecord
    {
        public int Counter { get; private set; }

        public CounterRecord()
        {
            Counter = 10;
        }

        public void CountUp()
        {
            Counter++;
        }

        public void CountDown()
        {
            Counter--;
        }

        //public override string ToString()
        //{
        //    return $"Current count: {Counter}";
        //}
    }
}
