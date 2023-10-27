using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hengerr
{
    public class Cso : Henger
    {
        double falVastagsag;

        public Cso(double sugar, double magassag, double falVastagsag) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagsag;
        }
        public Cso(double sugar, double magassag) : base(sugar, magassag)
        {
            this.falVastagsag = 1;
        }

        public double FalVastagsag { get => falVastagsag; }

        public override double Terfogat()
        {
            return base.Terfogat() - (Math.Pow((Sugar-falVastagsag), 2) *Math.PI * Magassag);
        }
        public override string ToString()
        {
            return base.ToString() + $"\tfalvastagság: {falVastagsag}";
        }
    }
}