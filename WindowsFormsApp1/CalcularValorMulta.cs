using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiro
{
    public partial class CalcularValorMulta : Form
    {
        public CalcularValorMulta()
        {
            InitializeComponent();
        }

        private void btnGerarMulta_Click(object sender, EventArgs e)
        {
            int velocidade = int.Parse(txtVelocidade.Text);
            string multa = "";

            if (velocidade <= 50)
            { 
                multa = "isento";
            }
            else if (velocidade <= 70)
            {
                multa = "R$ 300";
            }
            else if (velocidade <= 100)
            {
                multa = "R$ 600";
            }
            else
            {
                multa = "R$ 1500";
            }

            MessageBox.Show(multa);
        }
    }
}
