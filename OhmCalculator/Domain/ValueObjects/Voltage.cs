using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmCalculator.Domain.ValueObjects
{
    class Voltage : Unit
    {
        private Resistance r;
        private Current i;

        public Voltage(string Value, short Exponent) : base(Value, Exponent)
        {
        }

        public Voltage(Resistance r, Current i)
        {
            this.Value = r.GetValue() * i.GetValue();
            this.Exponent = (Int16)Magnitude.UNIT;
        }
    }
}
