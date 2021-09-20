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
    public partial class DesafioVotacao : Form
    {
        public DesafioVotacao()
        {
            InitializeComponent();
        }

        int vezesApertado = 0;
        int votosCandidatoA = 0;
        int votosCandidatoB = 0;
        int votosCandidatoC = 0;

        double votoTotal = 0;
        string mensagem = "";

        private void btnVoto_Click(object sender, EventArgs e)
        {
            vezesApertado++;

            if (rdCandidatoA.Checked)
                votosCandidatoA++;

            if (rdCandidatoB.Checked)
                votosCandidatoB++;

            if (rdCandidatoC.Checked)
                votosCandidatoC++;

            MessageBox.Show("Voto computado");

            if (vezesApertado >= 10)
                btnEncerrar.Enabled = true;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Você tem certeza?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            rdCandidatoA.Visible = false;
            rdCandidatoB.Visible = false;
            rdCandidatoC.Visible = false;

            if (votosCandidatoA > votosCandidatoB && votosCandidatoA > votosCandidatoC)
            {
                votoTotal = votosCandidatoA * 100 / (votosCandidatoA + votosCandidatoB + votosCandidatoC);
                mensagem = "candidato A venceu com " + votoTotal + "%";
            }
            else if (votosCandidatoB > votosCandidatoC && votosCandidatoB > votosCandidatoA)
            {
                votoTotal = votosCandidatoB * 100 / (votosCandidatoA + votosCandidatoB + votosCandidatoC);
                mensagem = "candidato B venceu com " + votoTotal + "%";
            }
            else if (votosCandidatoC > votosCandidatoA && votosCandidatoC > votosCandidatoB)
            {
                votoTotal = votosCandidatoC * 100 / (votosCandidatoA + votosCandidatoB + votosCandidatoC);
                mensagem = "candidato C venceu com " + votoTotal + "%";
            }
            else if (votosCandidatoA == votosCandidatoB)
            {
                mensagem = "Segundo turno: Candidato A, candidato B";
            }
            else if (votosCandidatoA == votosCandidatoC)
            {
                mensagem = "Segundo turno: Candidato A, candidato C";
            }
            else if (votosCandidatoB == votosCandidatoC)
            {
                mensagem = "Segundo turno: Candidato B, candidato C";
            }
            else if (votosCandidatoA == votosCandidatoB && votosCandidatoA == votosCandidatoC)
            {
                mensagem = "Empate entre os 3 candidatos";
            }

            MessageBox.Show(mensagem);
            btnEncerrar.Enabled = false;
            btnVoto.Enabled = false;
        }
    }
}
