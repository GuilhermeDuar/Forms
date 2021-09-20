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
    public partial class Voto : Form
    {
        public Voto()
        {
            InitializeComponent();
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            if (txtNascimento.Text == "")
            {
                return;
            }
            int anoNascimento = int.Parse(txtNascimento.Text);
            string resultado = ConferirIdadePorAnoAtual(anoNascimento);
            MessageBox.Show(resultado);
        }

        string ConferirIdadePorAnoAtual(int idade)
        {
            int anoAtual = DateTime.Now.Year;
            if (anoAtual - idade > 16)
            {
                return "Pode Votar";
            }
            return "Você não poderá votar";
        }





    }
}
