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
    public partial class A8De0AteDigitado : Form
    {
        public A8De0AteDigitado()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            //Imprimir na tela de 0 até o valor digitado na TextBox

            int numero = int.Parse(txtNumero.Text);
            string mensagem = "";

            List<int> numeros = new List<int>();

            for (int i = 0; i <= numero; i++)
            {
                numeros.Add(i);
                mensagem += numeros[i] + Environment.NewLine;
            }
            MessageBox.Show(mensagem);
        }
    }
}
