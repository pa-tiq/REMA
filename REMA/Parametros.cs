using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMA
{
    public class Parametros
    {
        public Parametros()
        {
            this.F = decimal.Zero;
            this.P = decimal.Zero;
            this.u = decimal.Zero;
            this.v = decimal.Zero;
            this.w = decimal.Zero;
            this.x = decimal.Zero;
            this.y = decimal.Zero;
            this.S1 =decimal.Zero;
            this.S2 =decimal.Zero;
            this.S3 = decimal.Zero;
        }

        public decimal u { get; set; }

        public decimal v { get; set; }

        public decimal w { get; set; }

        public decimal F { get; set; }

        public decimal P { get; set; }

        public decimal x { get; set; }

        public decimal y { get; set; }

        public decimal S1 { get; set; }

        public decimal S2 { get; set; }

        public decimal S3 { get; set; }



    }
}
