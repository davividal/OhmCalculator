using OhmCalculator.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmCalculator.Domain.Services
{
    abstract class OhmLaw
    {
        public Voltage v { get; set; }
        public Current i { get; set; }
        public Resistance r { get; set; }
    }
}
