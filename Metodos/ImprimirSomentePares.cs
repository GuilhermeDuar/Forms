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
    public partial class ImprimirSomentePares : Form
    {
        public ImprimirSomentePares()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (NumerosPares(Convert.ToDouble(textBox1.Text)))
            {
                MessageBox.Show("O numero é par");
            }
            else
            {
                MessageBox.Show("O numero não é par");
            }
        }
         
        bool NumerosPares(double numero)
        {
            return numero % 2 == 0;
        }
       
    }
}
