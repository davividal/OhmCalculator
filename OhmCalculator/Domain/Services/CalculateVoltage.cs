using System;
using OhmCalculator.Domain.ValueObjects;

namespace OhmCalculator.Domain.Services
{
    class CalculateVoltage : OhmLaw
    {
        public String GetVoltageByResistanceAndCurrent()
        {
            return (new Voltage(this.r, this.i)).ToString();
        }
    }
}