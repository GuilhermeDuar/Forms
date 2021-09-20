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
    public partial class CadastrarAluno : Form
    {

        List<string> nomes = new List<string>();

        public CadastrarAluno()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nomes.Count; i++)
            {
                if (nomes[i] == txtPesquisarNome.Text)
                {
                    MessageBox.Show("Aluno já cadastrado");
                    return;
                }
            }

            MessageBox.Show("Aluno não encontrado.");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string mensagem = "";

            for (int i = 0; i < nomes.Count; i++)
            {
                mensagem += nomes[i] + Environment.NewLine;
            }

            MessageBox.Show(mensagem);
        }
    }
}
