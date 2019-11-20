using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMA
{
    public class Calculos
    {
        public Calculos(Parametros prm)
        {
            this.LF = prm.u + prm.v;
            this.LP = prm.u;
            this.Ltotal = prm.u + prm.v + prm.w;
            //P é a força distribuída e F é a força concentrada
            this.Ay = (prm.F * (1 - (LF / Ltotal)) + (prm.P * LP / 2) * (1 + ((2 * LP) / (3 * Ltotal))));
            this.Dy = (prm.P * LP / 2) + prm.P - Ay;
        }

        public decimal Ltotal
        {
            get { return Ltotal; }
            set { Ltotal = value; }
        }

        public decimal LF
        {
            get { return LF; }
            set { LF = value; }
        }

        public decimal LP
        {
            get { return LP; }
            set { LP = value; }
        }

        public decimal Ay
        {
            get { return Ay; }
            set { Ay = value; }
        }

        public decimal Dy
        {
            get { return Dy; }
            set { Dy = value; }
        }

        public decimal Dy
        {
            get { return Dy; }
            set { Dy = value; }
        }

    }
}
