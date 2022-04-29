using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyszog
{
    public class Class1
    {
        public double Side { get; set; }

        public Class1(double side)
        {
            this.Side = side;
        }

        public double Kerulet()
        {
            return 4 * this.Side;
        }

        public double Terulet()
        {
            return Math.Pow(this.Side,2);
        }
        public double Atlo()
        {
            return Math.Sqrt(Math.Pow(this.Side, 2)*2);
        }
    }
}
