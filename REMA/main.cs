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
    public partial class Main : Form
    {
        Parametros prm = new Parametros();
        Calculos cal = new Calculos();

        public Main()
        {
            InitializeComponent();
            ConfigurarCampos();
            AtualizarCampos();
        }

        private void AtualizarCampos()
        {
            var campos = Campos();
            campos.ForEach(x => x.Update());
        }

        private List<NumericUpDown> Campos()
        {
            var campos = new List<NumericUpDown>();

            campos.Add(numericUpDownF);
            campos.Add(numericUpDownP);
            campos.Add(numericUpDownU);
            campos.Add(numericUpDownV);
            campos.Add(numericUpDownW);
            campos.Add(numericUpDownX);
            campos.Add(numericUpDownY);
            campos.Add(numericUpDownS1);
            campos.Add(numericUpDownS2);
            campos.Add(numericUpDownS3);

            return campos;
        }

        private void PreencherValoresPadrao()
        {            
            prm.F = new decimal(200.0);
            prm.P = new decimal(2.0);
            prm.u = new decimal(150.0e-3);
            prm.v = new decimal(50.0e-3);
            prm.w = new decimal(50.0e-3);
            prm.x = new decimal(24.0e-3);
            prm.y = new decimal(76.0e-3);
            prm.S1 = prm.u / 2;
            prm.S2 = (prm.u + (prm.u + prm.v)) / 2;
            prm.S3 = ((prm.u + prm.v) + (prm.u + prm.v + prm.w)) / 2;

            PreencherTela(prm);
            AtualizarCampos();
        }

        private void PreencherTela(Parametros prm)
        {
            numericUpDownF.Value = prm.F;
            numericUpDownP.Value = prm.P;
            numericUpDownU.Value = prm.u * new decimal(1000);
            numericUpDownV.Value = prm.v * new decimal(1000);
            numericUpDownW.Value = prm.w * new decimal(1000);
            numericUpDownX.Value = prm.x * new decimal(1000);
            numericUpDownY.Value = prm.y * new decimal(1000);
            numericUpDownS1.Value = prm.S1* new decimal(1000);
            numericUpDownS2.Value = prm.S2* new decimal(1000);
            numericUpDownS3.Value = prm.S3 * new decimal(1000);
        }                                 
                                          
        private void PreencherParametros(Parametros prm)
        {
            prm.F = numericUpDownF.Value;
            prm.P = numericUpDownP.Value;
            prm.u = numericUpDownU.Value * new decimal(1e-3);
            prm.v = numericUpDownV.Value * new decimal(1e-3);
            prm.w = numericUpDownW.Value * new decimal(1e-3);
            prm.x = numericUpDownX.Value * new decimal(1e-3);
            prm.y = numericUpDownY.Value * new decimal(1e-3);
            prm.S1 = numericUpDownS1.Value * new decimal(1e-3);
            prm.S2 = numericUpDownS2.Value * new decimal(1e-3);
            prm.S3 = numericUpDownS3.Value * new decimal(1e-3);
        }

        private void ConfigurarCampos()
        {
            var campos = Campos();

            foreach(var campo in campos)
            {
                campo.Value = decimal.Zero;
                campo.Maximum = decimal.MaxValue;
                campo.Minimum = decimal.Zero;
                campo.DecimalPlaces = 2;
                campo.KeyPress += campo_KeyPress;
            }
        }

        private void campo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //if ((e.KeyChar == '.') && ((sender as NumericUpDown).Value.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if(validar())
            {
                PreencherParametros(prm);
                cal.Calcular(prm);

                Form respostas = new respostas(cal,prm);
                respostas.Show();
            }
            else
            {

            }            
        }

        private bool validar()
        {
            var campos = Campos();
            var valor = decimal.Zero;

            if (numericUpDownS1.Value < 0 || numericUpDownS1.Value > numericUpDownU.Value) return false;
            if (numericUpDownS2.Value < numericUpDownU.Value ||
                numericUpDownS2.Value > numericUpDownU.Value + numericUpDownV.Value) return false;
            if (numericUpDownS3.Value < numericUpDownU.Value + numericUpDownV.Value || 
                numericUpDownS3.Value > numericUpDownU.Value + numericUpDownV.Value + 
                numericUpDownW.Value) return false;

            foreach (var x in campos)
            {
                decimal.TryParse(x.Value.ToString(), out valor);
                if(valor <= decimal.Zero)
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

            return true;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            var campos = Campos();
            campos.ForEach(x => x.Value = decimal.Zero);
            AtualizarCampos();
        }

        private void buttonValoresPadrao_Click(object sender, EventArgs e)
        {
            PreencherValoresPadrao();
        }
    }
}
