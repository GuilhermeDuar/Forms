using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace primeiro
{
    public partial class A6ProdutoeDesconto : Form
    {
        public A6ProdutoeDesconto()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //Caso o valor do produto seja maior que 500, recebe o desconto de 90%

            string nomeProduto = txtNomeProduto.Text;
            double valorProduto = double.Parse(txtValorProduto.Text);
            double precoFinal = valorProduto;

            if (valorProduto >= 500 && cbFormaPagamento.SelectedIndex == 0)
                precoFinal = valorProduto * 0.90;

            MessageBox.Show("O produto " + nomeProduto + " custará " + precoFinal.ToString("C2"));
        }

       
    }
}
