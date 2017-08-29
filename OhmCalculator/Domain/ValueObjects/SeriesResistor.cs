using OhmCalculator.Domain.ValueObjects.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmCalculator.Domain.ValueObjects
{
    class SeriesResistor : Unit
    {
        public Resistor Req { get; set; }
        public Voltage v { get; set; }
        public List<Resistor> Resistors;

        public static SeriesResistor operator +(SeriesResistor s, Resistor r2)
        {
            Resistance eq = new Resistance(s.Req.r.GetValue() + r2.r.GetValue());

            SeriesResistor sr = new SeriesResistor()
            {
                Req = new Resistor(eq, s.v),
                v = s.v
            };

            sr.Resistors.AddRange(s.Resistors);
            sr.Resistors.Add(r2);

            return sr;
        }
    }
}
