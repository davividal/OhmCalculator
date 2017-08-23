using OhmCalculator.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmCalculator.Domain.Services
{
    class CalculateCurrent : OhmLaw
    {
        public String GetCurrentByVoltageAndResistance()
        {
            return (new Current(this.v, this.r)).ToString();
        }
    }
}
