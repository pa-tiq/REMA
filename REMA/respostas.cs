using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMA
{
    public partial class respostas : Form
    {

        public respostas(Calculos cal,Parametros par)
        {
            InitializeComponent();
            ConfigurarCampos();
            PreencherTela(cal,par);
        }

        private void AtualizarCampos()
        {       
            Campos().ForEach(x => x.Update());
        }

        private List<NumericUpDown> Campos()
        {
            var campos = new List<NumericUpDown>();
         
            campos.Add(numericUpDownAy);
            campos.Add(numericUpDownDy);
            campos.Add(numericUpDownLP);
            campos.Add(numericUpDownLF);
            campos.Add(numericUpDownLT);
            campos.Add(numericUpDownV1);
            campos.Add(numericUpDownV2);
            campos.Add(numericUpDownV3);
            campos.Add(numericUpDownM1);
            campos.Add(numericUpDownM2);
            campos.Add(numericUpDownM3);         

            return campos;
        }


        private List<TextBox> CamposTexto()
        {
            var campos = new List<TextBox>();

            campos.Add(textBoxV1);
            campos.Add(textBoxV2);
            campos.Add(textBoxV3);
            campos.Add(textBoxM1);
            campos.Add(textBoxM2);
            campos.Add(textBoxM3);

            return campos;
        }

        private void ConfigurarCampos()
        {
            var campos = Campos();
            var campost = CamposTexto();
            
            foreach (var campo in campos)
            {
                campo.Value = decimal.Zero;
                campo.Maximum = decimal.MaxValue;
                campo.Minimum = decimal.MinValue;
                campo.DecimalPlaces = 2;
                campo.ReadOnly = true;
                campo.Increment = decimal.Zero;
            }

            foreach (var campo in campost)
            {
                campo.ReadOnly = true;
            }
        }

        private void PreencherTela(Calculos cal,Parametros par)
        {
            numericUpDownAy.Value = cal.Ay;
            numericUpDownDy.Value = cal.Dy;
            numericUpDownLP.Value = cal.LP;
            numericUpDownLF.Value = cal.LF;
            numericUpDownLT.Value = cal.LT;

            numericUpDownV1.Value = cal.V1;         
            numericUpDownV2.Value = cal.V2;
            numericUpDownV3.Value = cal.V3;
            numericUpDownM1.Value = cal.M1;
            numericUpDownM2.Value = cal.M2;
            numericUpDownM3.Value = cal.M3;

            textBoxV1.Text = cal.plotV1();
            textBoxV2.Text = cal.plotV2();
            textBoxV3.Text = cal.plotV3();
            textBoxM1.Text = cal.plotM1();
            textBoxM2.Text = cal.plotM2();
            textBoxM3.Text = cal.plotM3();

            AtualizarCampos();
           
            Graficos grV1 = new Graficos(cal,par);
            Graficos grV2 = new Graficos(cal,par);
            Graficos grV3 = new Graficos(cal,par);
            Graficos grM1 = new Graficos(cal,par);
            Graficos grM2 = new Graficos(cal,par);
            Graficos grM3 = new Graficos(cal,par);

            grV1.PlotV1(pictureBoxV1);
            grV2.PlotV2(pictureBoxV2);
            grV3.PlotV3(pictureBoxV3);
            grM1.PlotM1(pictureBoxM1);
            grM2.PlotM2(pictureBoxM2);
            grM3.PlotM3(pictureBoxM3);

            pictureBoxV1.Update();
            pictureBoxV2.Update();
            pictureBoxV3.Update();
            pictureBoxM1.Update();
            pictureBoxM2.Update();
            pictureBoxM3.Update();

        }
    }
}
