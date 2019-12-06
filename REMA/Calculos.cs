using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMA
{
    public class Calculos
    {

        private Parametros prm;
        private int d = 2; //casas decimais

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

        public void Calcular(Parametros p)
        {
            prm = p;
            this.LF = prm.u + prm.v;
            this.LP = prm.u;
            this.LT = prm.u + prm.v + prm.w;
            //P é a força distribuída e F é a força concentrada
            this.Ay = (prm.F * (1 - (LF / LT)) + Gama() * (1 + Beta()));
            this.Dy = Gama() + prm.F - Ay;
            this.V1 = retornarV1();
            this.M1 = retornarM1();
            this.V2 = retornarV2();
            this.M2 = retornarM2();
            this.V3 = retornarV3();
            this.M3 = retornarM3();
        }

        private decimal Beta()
        {
            return ((2 * LP) / (3 * LT));
        }

        private decimal Gama()
        {
            return (prm.P * LP) / 2;
        }

        public float plotV1(float s1)
        {
            return (float)Ay - (((float)prm.P / (2 * (float)LP)) * s1 * s1);
        }

        public string plotV1()
        {
            return decimal.Round(Ay,d) + " - " + decimal.Round((prm.P / (2 * LP)), d) + " + x^2";
        }

        private decimal retornarV1()
        {
            return Ay - ((prm.P / (2 * LP)) * prm.S1 * prm.S1);
        }

        public string plotM1()
        {
            return decimal.Round(Ay, d) + " * x - " + decimal.Round(((prm.P / (6 * LP))), d) + " * x^3";
        }

        public float plotM1(float s1)
        {
            return (float)Ay * s1 - (((float)prm.P * s1 * s1 * s1 / (6 * (float)LP)));
        }

        private decimal retornarM1()
        {
            return Ay * prm.S1 - ((prm.P * prm.S1 * prm.S1 * prm.S1 / (6 * LP)));
        }

        public float plotV2(float s2)
        {
            return (float)(Ay - Gama());
        }

        public string plotV2()
        {
            return decimal.Round((Ay - Gama()), d).ToString();
        }

        private decimal retornarV2()
        {
            return Ay - Gama();
        }

        public float plotM2(float s2)
        {
            return (float)Ay * s2 - (float)Gama() * s2 + (float)Gama() * (float)Beta() * (float)LT;
        }

        public string plotM2()
        {
            return decimal.Round(Ay, d) + " * x - " + decimal.Round(Gama(), d) +  
                " * x + " + decimal.Round(Gama() * Beta() * LT, d);
        }

        private decimal retornarM2()
        {
            return Ay * prm.S2 - Gama()*prm.S2 + Gama()*Beta()*LT;
        }

        public float plotV3(float s3)
        {
            return (float)(Ay - Gama() - prm.F);
        }

        public string plotV3()
        {
            return decimal.Round((Ay - Gama() - prm.F), d).ToString();
        }

        private decimal retornarV3()
        {
            return Ay - Gama() - prm.F;
        }

        public float plotM3(float s3)
        {
            return (float)(Ay - Gama() - prm.F) * s3 +
                (float)(Gama() * Beta() * LT) + (float)(prm.F * LP);
        }

        public string plotM3()
        {
            return decimal.Round((Ay - Gama() - prm.F), d) + " * x + " +
               decimal.Round(((Gama() * Beta() * LT) + (prm.F * LP)), d);
        }

        private decimal retornarM3()
        {
            return (Ay - Gama() - prm.F) * prm.S3 + (Gama() * Beta() * LT) + (prm.F * LP);
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
