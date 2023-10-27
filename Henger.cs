using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hengerr
{
    public class Henger
    {
        double magassag;
        double sugar;
        static double szuletesSzamlalo = 0;

        public Henger(double sugar, double magassag)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo++;
        }

        public double Magassag { get => magassag; }
        public double Sugar { get => sugar; }
        public static double SzuletesSzamlalo { get => szuletesSzamlalo; }

        public virtual double Terfogat()
        {
            return Math.Pow(sugar, 2) * Math.PI * magassag;
        }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat: {Math.Round(Terfogat(), 2)}; sugár: {sugar}; magasság: {magassag};";
        }
    }
}