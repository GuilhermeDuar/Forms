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
    public partial class PodeVotar : Form
    {
        public PodeVotar()
        {
            InitializeComponent();
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            int anoAtual = DateTime.Now.Year;
            int anoNascimento = int.Parse(txtNascimento.Text);

            MessageBox.Show(anoAtual - anoNascimento >= 16 ? "Pode votar este ano!" : "Não pode votar!");
        }
    }
}
