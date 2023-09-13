using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live
{
    internal class CounterClass
    {
        public int Counter { get; private set; }

        public CounterClass()
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

        public override string ToString()
        {
            return $"Current count: {Counter}";
        }

        public override bool Equals(object? obj)
        {
            // Om object är av samm typ/referens? som...
            if (obj is CounterClass counterClass)
            {
                if (counterClass.Counter == Counter)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
