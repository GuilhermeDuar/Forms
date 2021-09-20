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
    public partial class SORTEIO : Form
    {
        public SORTEIO()
        {
            InitializeComponent();
            //Quando o usuario pressionar enter o btnCdastrar será clicado
            AcceptButton = btnCadastrar;
            Text = "Sortei";
            this.txtCadastro.TabIndex = 0;
            // para iniciar logo na caixa de texto cadastro

        }
        List<string> nomes = new List<string>();

        Random rdm = new Random();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            nomes.Add(txtCadastro.Text);
            txtCadastro.Focus();
            txtCadastro.Clear();
            SincronizarListaComCaixaDeTexto();

            // servem para adicionar o texto de uma lista em uma txt
            //txtNomes.AppendText(txtCadastro.Text + "\r\n");
            // txtNomes.Text += txtCadastro.Text + "\r\n";
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            int numeroSorteado = rdm.Next(0, nomes.Count);
            string nome = nomes[numeroSorteado];
            nomes.RemoveAt(numeroSorteado);
            MessageBox.Show(nome + " Ganhou!");
            SincronizarListaComCaixaDeTexto();
        }


        void SincronizarListaComCaixaDeTexto()
        {
            txtNomes.Text = "";
            for (int i = 0; i < nomes.Count; i++)
            {
                txtNomes.Text = txtNomes.Text + nomes[i] + "\r\n";
            }

        }
    }
}
