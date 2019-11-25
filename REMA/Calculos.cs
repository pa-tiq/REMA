using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMA
{
    public class Calculos
    {

        public Calculos()
        {
            this.LF = decimal.Zero;
            this.LP = decimal.Zero;
            this.LT = decimal.Zero;
            //P é a força distribuída e F é a força concentrada
            this.Ay = decimal.Zero;
            this.Dy = decimal.Zero;
            this.V1 = decimal.Zero;
            this.M1 = decimal.Zero;
            this.V2 = decimal.Zero;
            this.M2 = decimal.Zero;
            this.V3 = decimal.Zero;
            this.M3 = decimal.Zero;
        }

        public void Calcular(Parametros prm)
        {
            this.LF = prm.u + prm.v;
            this.LP = prm.u;
            this.LT = prm.u + prm.v + prm.w;
            //P é a força distribuída e F é a força concentrada
            this.Ay = (prm.F * (1 - (LF / LT)) + Gama(prm) * (1 + Beta()));
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
            return ((2 * LP) / (3 * LT));
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
            return Ay * prm.S2 - Gama(prm)*prm.S2 + Gama(prm)*Beta()*LT;
        }

        private decimal retornarV3(Parametros prm)
        {
            return Ay - Gama(prm) - prm.F;
        }

        private decimal retornarM3(Parametros prm)
        {
            return (Ay - Gama(prm) - prm.F) * prm.S3 + (Gama(prm) * Beta() * LT) + (prm.F * LP);
        }

        public decimal LT { get; set; }

        public decimal LF { get; set; }

        public decimal LP { get; set; }

        public decimal Ay { get; set; }

        public decimal Dy { get; set; }

        public decimal V1 { get; set; }

        public decimal M1 { get; set; }

        public decimal V2 { get; set; }

        public decimal M2 { get; set; }

        public decimal V3 { get; set; }

        public decimal M3 { get; set; }

    }
}
