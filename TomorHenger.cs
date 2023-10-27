using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hengerr
{
    public class TomorHenger : Henger
    {
        double fajsuly;

        public TomorHenger(double sugar, double magassag,  double fajsuly) : base(sugar, magassag)
        {
            this.fajsuly = fajsuly;
        }
        public TomorHenger(double sugar, double magassag) : base(sugar, magassag)
        {
            this.fajsuly = 7.87;
        }
        public double Fajsuly { get => fajsuly; }
        public double Suly { get => fajsuly * Terfogat(); }

        public override string ToString()
        {
            return base.ToString() + $"\tfajsúly: {fajsuly}";
        }
    }
}