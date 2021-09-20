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
    public partial class CalcularMedia : Form
    {
        public CalcularMedia()
        {
            InitializeComponent();
        }

        private void btnGerarMedia_Click(object sender, EventArgs e)
        {
            double media = (double.Parse(txtNota1.Text) + double.Parse(txtNota2.Text) + double.Parse(txtNota3.Text)) / 3;

            MessageBox.Show(media < 5 ? "Reprovado!" : media < 7 ? "Recuperação!" : "Aprovado!");
        }
    }
}
