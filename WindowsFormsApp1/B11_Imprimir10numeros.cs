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
    public partial class B11_Imprimir10numeros : Form
    {
        public B11_Imprimir10numeros()
        {
            InitializeComponent();
        }

        List<int> numeros = new List<int>();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Inserir 10 números em uma lista sem permitir repitidos. Quando chegar a 10 exibir todos os números

            int numeroInformado = int.Parse(txtNumero.Text);
            string mensagem = "";

            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeroInformado == numeros[i])
                {
                    MessageBox.Show("Nao coloque numeros repetidos");
                    return;
                }
            }

            numeros.Add(numeroInformado);
            MessageBox.Show("Número adicionado");

            if (numeros.Count == 10)
            {
                for (int i = 0; i < numeros.Count; i++)
                {
                    mensagem += numeros[i] + Environment.NewLine;
                }

                btnAdicionar.Enabled = false;

                MessageBox.Show(mensagem);
            }
        }
    }
}
