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
        }

        private List<TextBox> Campos()
        {
            var campos = new List<TextBox>();

            campos.Add(textBoxF);
            campos.Add(textBoxP);
            campos.Add(textBoxU);
            campos.Add(textBoxV);
            campos.Add(textBoxW);
            campos.Add(textBoxTransx);
            campos.Add(textBoxTransy);

            return campos;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            Validate();
            MessageBox.Show("Thanks!");
        }

        private void Validate()
        {
            var campos = Campos();

            foreach (var x in campos)
            { 
                

            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            var campos = Campos();
            campos.ForEach(x => x.Clear());
        }
    }
}
