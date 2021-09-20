using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorreçãoProva19._05
{
    public partial class questao4 : Form
    {
        public questao4()
        {
            InitializeComponent();
        }

        string palavra = "";
        int tentativas = 0;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            palavra = txtPalavra.Text;
            txtPalavra.Clear();
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            tentativas++;
            if (txtTentativa.Text != palavra)
            {
                if (tentativas == 5)
                {
                    MessageBox.Show("Voce perdeu. A palavra era " + palavra);
                    tentativas = 0;
                }
                return;
            }

            MessageBox.Show("Voce acertou em " + tentativas);

        }
    }
}
