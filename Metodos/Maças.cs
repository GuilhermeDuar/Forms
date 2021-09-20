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
    public partial class Maças : Form
    {
        public Maças()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            int quantidadeMaças = int.Parse(txtMaca.Text);
            double preço = CalcularPreço(quantidadeMaças);
            MessageBox.Show("O preço a pagar é de " + preço, "TOTAL");
        }

        double CalcularPreço(int qtdMaças)
        {
            if (qtdMaças < 12)
            {
                return qtdMaças * 1.30;
            }
            return qtdMaças;
        }
    }
}
