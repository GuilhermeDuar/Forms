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
    public partial class ProcurarNomeEmLista : Form
    {
        public ProcurarNomeEmLista()
        {
            InitializeComponent();
        }

        List<string> nomes = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            // Só funciona por o metodo criado retorna uma string e MB aceita string
            MessageBox.Show(AdicionarNome(txtCadastrarNome.Text));
            txtCadastrarNome.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TERNARIO para compara dentro do MB
            MessageBox.Show(PesquisarNomes(txtProcurarNome.Text) ? "Nome encontrado:" + txtProcurarNome.Text : "Nome não encontrado");
            txtCadastrarNome.Clear();

        }
        string AdicionarNome (string nome)
        {
            if (nome == "")
            {
                return "Adicione um nome";
            }
            if (nomes.Count == 10)
            {
                return "número máximo atingido";
            }
            nomes.Add(nome);
            return "Nome adicionado com sucesso";
        }
        bool PesquisarNomes( string nome)
        {
            for (int i = 0; i < nomes.Count; i++)
            {
                if (nomes[i] == nome)
                {
                    return true;
                }
            }
            return false;
            //return final sempre fora do for para não ler so o 1 nome
        }
    }
}
