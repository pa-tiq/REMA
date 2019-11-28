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
        Graficos gr = new Graficos(pictre);

        public respostas(Calculos cal)
        {
            InitializeComponent();
            ConfigurarCampos();
            PreencherTela(cal);
        }

        private void AtualizarCampos()
        {
            var campos = Campos();
            campos.ForEach(x => x.Update());
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

        private void ConfigurarCampos()
        {
            var campos = Campos();

            foreach (var campo in campos)
            {
                campo.Value = decimal.Zero;
                campo.Maximum = decimal.MaxValue;
                campo.Minimum = decimal.MinValue;
                campo.DecimalPlaces = 2;
                campo.ReadOnly = true;
            }
        }

        private void PreencherTela(Calculos cal)
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

            AtualizarCampos();
        }
    }
}
