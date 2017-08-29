using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmCalculator.Domain.ValueObjects.Components
{
    class Resistor
    {
        public Resistance r { get; set; }
        public Voltage v { get; set; }
        public Current i { get; set; }

        public Resistor(Resistance r, Voltage v)
        {
            this.r = r;
            this.v = v;
            this.i = new Current(v, r);
        }

        public Resistor(Resistance r, Current i)
        {
            this.r = r;
            this.v = new Voltage(r, i);
            this.i = i;
        }

        public Resistor(Voltage v, Current i)
        {
            this.r = new Resistance(v, i);
            this.v = v;
            this.i = i;
        }
    }
}
