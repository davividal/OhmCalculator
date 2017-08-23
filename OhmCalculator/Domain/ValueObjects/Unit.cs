using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmCalculator.Domain.ValueObjects
{
    class Unit
    {
        protected Double Value;
        protected Int16 Exponent;

        public enum Magnitude : Int16
        {
            NANO = -9,
            MICRO = -6,
            MILI = -3,
            UNIT = 0,
            KILO = 3,
            MEGA = 6
        }

        protected Unit() { }

        public Unit(string Value)
        {
            this.Value = Convert.ToDouble(Value);
            this.Exponent = 0;
        }

        public Unit(double Value)
        {
            this.Value = Value;
            this.Exponent = 0;
        }

        public Unit(string Value, short Exponent)
        {
            this.Value = Convert.ToDouble(Value);
            this.Exponent = Exponent;
        }

        override public String ToString()
        {
            return String.Format("{0}", GetValue());
        }

        public Double GetValue()
        {
            return this.Value * Math.Pow(10, this.Exponent);
        }
    }
}
