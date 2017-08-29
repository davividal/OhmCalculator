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

        public Resistance(double Value, Voltage v)
        {
            this.Value = Value;
            this.Exponent = (Int16)Magnitude.UNIT;
        }

        public Resistance(Voltage v, Current i)
        {
            this.Value = v.GetValue() / i.GetValue();
            this.Exponent = (Int16)Magnitude.UNIT;
        }

        public Resistance(string Value, short Exponent) : base(Value, Exponent)
        {
        }

        public static Resistance operator +(Resistance r1, Resistance r2)
        {
            return new Resistance(r1.Value + r2.Value);
        }
    }
}
