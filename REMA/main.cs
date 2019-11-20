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

        private void PreencherValoresPadrao()
        {
            numericUpDownF.Value = new decimal(200.0);
            numericUpDownP.Value = new decimal(2.0);
            numericUpDownU.Value = new decimal(150.0);
            numericUpDownV.Value = new decimal(50.0);
            numericUpDownW.Value = new decimal(50.0);
            numericUpDownTransX.Value = new decimal(24.0);
            numericUpDownTransY.Value = new decimal(76.0);
            AtualizarCampos();
        }

        private List<NumericUpDown> Campos()
        {
            var campos = new List<NumericUpDown>();

            campos.Add(numericUpDownF);
            campos.Add(numericUpDownP);
            campos.Add(numericUpDownU);
            campos.Add(numericUpDownV);
            campos.Add(numericUpDownW);
            campos.Add(numericUpDownTransX);
            campos.Add(numericUpDownTransY);

            return campos;
        }

        private void ConfigurarCampos()
        {
            var campos = Campos();

            foreach(var campo in campos)
            {
                campo.Value = decimal.Zero;
                campo.Maximum = 10000.0M;
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
                MessageBox.Show("Thanks!");
            }
            else
            {

            }            
        }

        private bool validar()
        {
            var campos = Campos();
            var valor = decimal.Zero;

            foreach (var x in campos)
            {
                decimal.TryParse(x.Value.ToString(), out valor);
                if(valor <= decimal.Zero)
                {
                    x.Focus();
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
