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
    public partial class METODOMaiorNumeroDaLista : Form
    {
        public METODOMaiorNumeroDaLista()
        {
            InitializeComponent();
        }

        List<string> numeros = new List<string>();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdicionarNumeros(txtNumero.Text));
            txtNumero.Clear();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O maior número é: " + ProcurarMaior());
        }

        string AdicionarNumeros(string numero)
        {
            numeros.Add(numero);
            return "Número adicionado com sucesso";
        }

        string ProcurarMaior()
        {
            return numeros.Max();
        }

       
    }
}
