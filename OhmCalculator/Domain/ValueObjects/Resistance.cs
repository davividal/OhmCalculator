using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmCalculator.Domain.ValueObjects
{
    class Resistance : Unit
    {
        private double v;

        public Resistance(double Value) : base(Value)
        {
        }

        public Resistance(Voltage v, Current i)
        {
            this.Value = v.GetValue() / i.GetValue();
            this.Exponent = (Int16)Magnitude.UNIT;
        }

        public Resistance(string Value, short Exponent) : base(Value, Exponent)
        {
        }
    }
}
