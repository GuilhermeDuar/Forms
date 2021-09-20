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
    public partial class B13_MaiorNumeroEPares : Form
    {
        public B13_MaiorNumeroEPares()
        {
            InitializeComponent();
        }

        List<int> numeros = new List<int>();
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Fazer o mesmo da Atividade 11, mas agora informando o maior número, menor e a quantidade de números pares

            int quantidade = numeros.Where(c => c % 2 == 0).Count();
            int numeroInformado = int.Parse(txtNumero.Text);

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
                
                MessageBox.Show("O maior número é " + numeros.Max() + ", O menor número é " + numeros.Min() + ", Números pares " + quantidade);
                btnAdicionar.Enabled = false;
            }
        }
    }
}
