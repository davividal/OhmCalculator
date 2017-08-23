using OhmCalculator.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmCalculator.Domain.Services
{
    class CalculateResistance : OhmLaw
    {
        public String GetResistanceByVoltageAndCurrent()
        {
            return (new Resistance(this.v, this.i)).ToString();
        }
    }
}
