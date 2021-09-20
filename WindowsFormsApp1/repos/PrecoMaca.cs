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
    public partial class PrecoMaca : Form
    {
        public PrecoMaca()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int quantidadeMaças = int.Parse(txtMaca.Text);
            double preço = quantidadeMaças < 12 ? quantidadeMaças * 1.30 : quantidadeMaças;

            MessageBox.Show("Preço total: " + preço.ToString("C2"));
        }
    }
}
