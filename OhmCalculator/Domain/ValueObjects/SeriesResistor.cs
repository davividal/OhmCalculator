using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmCalculator.Domain.ValueObjects
{
    class SeriesResistor : Unit
    {
        public Resistance Req { get; set; }

        public static SeriesResistor operator +(SeriesResistor s, Resistance r2)
        {
            return new SeriesResistor()
            {
                Req = new Resistance(s.Req.GetValue() + r2.GetValue())
            };
        }
    }
}
