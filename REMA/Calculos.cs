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
            this.Ay = (prm.F * (1 - (LF / Ltotal)) + Gama(prm) * (1 + Beta()));
            this.Dy = Gama(prm) + prm.F - Ay;
            this.V1 = retornarV1(prm);
            this.M1 = retornarM1(prm);
            this.V2 = retornarV2(prm);
            this.M2 = retornarM2(prm);
            this.V3 = retornarV3(prm);
            this.M3 = retornarM3(prm);
        }

        private decimal Beta()
        {
            return ((2 * LP) / (3 * Ltotal));
        }

        private decimal Gama(Parametros prm)
        {
            return (prm.P * LP) / 2;
        }

        private decimal retornarV1(Parametros prm)
        {
            return Ay - ((prm.P / (2 * LP)) * prm.S1 * prm.S1);
        }

        private decimal retornarM1(Parametros prm)
        {
            return Ay * prm.S1 - ((prm.P * prm.S1 * prm.S1 * prm.S1 / (6 * LP)));
        }

        private decimal retornarV2(Parametros prm)
        {
            return Ay - Gama(prm);
        }

        private decimal retornarM2(Parametros prm)
        {
            return Ay * prm.S2 - Gama(prm)*prm.S2 + Gama(prm)*Beta()*Ltotal;
        }

        private decimal retornarV3(Parametros prm)
        {
            return Ay - Gama(prm) - prm.F;
        }

        private decimal retornarM3(Parametros prm)
        {
            return (Ay - Gama(prm) - prm.F) * prm.S3 + (Gama(prm) * Beta() * Ltotal) + (prm.F * LP);
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

        public decimal V1
        {
            get { return V1; }
            set { V1 = value; }
        }

        public decimal M1
        {
            get { return M1; }
            set { M1 = value; }
        }

        public decimal V2
        {
            get { return V2; }
            set { V2 = value; }
        }

        public decimal M2
        {
            get { return M2; }
            set { M2 = value; }
        }

        public decimal V3
        {
            get { return V3; }
            set { V3 = value; }
        }

        public decimal M3
        {
            get { return M3; }
            set { M3 = value; }
        }

    }
}
