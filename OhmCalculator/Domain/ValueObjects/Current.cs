using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmCalculator.Domain.ValueObjects
{
    class Current : Unit
    {
        public Current(string Value, short Exponent) : base(Value, Exponent)
        {
        }

        public Current(Voltage v, Resistance r)
        {
            this.Value = v.GetValue() / r.GetValue();
            this.Exponent = (Int16)Magnitude.UNIT;
        }
    }
}
