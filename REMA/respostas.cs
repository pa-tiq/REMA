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
        private Calculos cal;
        private Parametros par;

        public respostas(Calculos c,Parametros p)
        {
            cal = c;
            par = p;

            InitializeComponent();
            ConfigurarCampos();
            PreencherTela();
        }


        private void AtualizarCampos()
        {       
            Campos().ForEach(x => x.Update());
            CamposEditaveis().ForEach(x => x.Update());
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

        private List<NumericUpDown> CamposEditaveis()
        {
            var campos = new List<NumericUpDown>();

            campos.Add(numericUpDownV1X);
            campos.Add(numericUpDownV2X);
            campos.Add(numericUpDownV3X);

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
            campos.Add(textBoxVM1);
            campos.Add(textBoxVM2);
            campos.Add(textBoxVM3);

            return campos;
        }

        private void ConfigurarCampos()
        {
            var campos = Campos();
            var campost = CamposTexto();
            var camposed = CamposEditaveis();
            
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

            foreach (var campo in camposed)
            {
                campo.Value = decimal.Zero;
                campo.Maximum = decimal.MaxValue;
                campo.Minimum = decimal.MinValue;
                campo.DecimalPlaces = 2;
                campo.KeyDown += Campo_KeyDown;
            }
        }

        private void Campo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                aplicar();
            }
        }

        private void PreencherTela()
        {
            numericUpDownAy.Value = cal.Ay;
            numericUpDownDy.Value = cal.Dy;
            numericUpDownLP.Value = cal.LP * new decimal(1e3);
            numericUpDownLF.Value = cal.LF * new decimal(1e3);
            numericUpDownLT.Value = cal.LT * new decimal(1e3);

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

            numericUpDownV1X.Value = par.S1* new decimal(1e3);
            numericUpDownV2X.Value = par.S2* new decimal(1e3);
            numericUpDownV3X.Value = par.S3* new decimal(1e3);

            textBoxVM1.Text = "0 a " + decimal.Round
                (cal.LP * new decimal(1e3), 2) + " mm";
            textBoxVM2.Text = decimal.Round(cal.LP * new decimal(1e3), 2) + " a " 
                + decimal.Round(cal.LF * new decimal(1e3), 2) + " mm";
            textBoxVM3.Text = decimal.Round(cal.LF * new decimal(1e3), 2) + " a " 
                + decimal.Round(cal.LT * new decimal(1e3), 2) + " mm";

            AtualizarCampos();
           
            Graficos gr = new Graficos(cal,par);

            gr.PlotV1(pictureBoxV1);
            gr.PlotV2(pictureBoxV2);
            gr.PlotV3(pictureBoxV3);
            gr.PlotM1(pictureBoxM1);
            gr.PlotM2(pictureBoxM2);
            gr.PlotM3(pictureBoxM3);

            pictureBoxV1.Update();
            pictureBoxV2.Update();
            pictureBoxV3.Update();
            pictureBoxM1.Update();
            pictureBoxM2.Update();
            pictureBoxM3.Update();

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validar()
        {
            var valor = decimal.Zero;
            foreach (var x in CamposEditaveis())
            {
                decimal.TryParse(x.Value.ToString(), out valor);
                if (valor <= decimal.Zero)
                {
                    if (!x.Focus())
                    {
                        for (var i = 0; i < tabControl1.TabPages.Count; i++)
                        {
                            tabControl1.SelectTab(i);
                            if (x.Focus()) break;
                        }
                    }

                    return false;
                }
            }

            if (numericUpDownV1X.Value * new decimal(1e-3) < 0 || numericUpDownV1X.Value * new decimal(1e-3) > cal.LP) return false;
            if (numericUpDownV2X.Value * new decimal(1e-3) < cal.LP || numericUpDownV2X.Value * new decimal(1e-3) > cal.LF) return false;
            if (numericUpDownV3X.Value * new decimal(1e-3) < cal.LF || numericUpDownV3X.Value * new decimal(1e-3) > cal.LT) return false;
            return true;
        }

        private void aplicar()
        {
            if (validar())
            {
                par.S1 = numericUpDownV1X.Value * new decimal(1e-3);
                par.S2 = numericUpDownV2X.Value * new decimal(1e-3);
                par.S3 = numericUpDownV3X.Value * new decimal(1e-3);

                cal.Calcular(par);

                PreencherTela();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aplicar();   
        }
    }
}
