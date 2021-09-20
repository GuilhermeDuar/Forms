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
    public partial class questao3 : Form
    {
        public questao3()
        {
            InitializeComponent();
        }
        List<double> numeros = new List<double>();

        //------------------------------------------botoes-------------------------------\\
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string mensagem = AdicionarNumeroPar(double.Parse(txtNumero.Text));
            MessageBox.Show(mensagem);
        }
        private void btnSomar_Click(object sender, EventArgs e)
        {
            double soma = CalcularSomaLista();
            MessageBox.Show(soma.ToString());
        }
        //------------------------------------------metodos-------------------------------\\

        string AdicionarNumeroPar(double numero)
        {
            if (numero % 2 == 1)
            {
                return "numero impar";
            }
            if (numeros.Count == 5)
            {
                return "lista cheia";
            }
            numeros.Add(numero);
            return "numero par adicionado";
        }

        double CalcularSomaLista()
        {
            return numeros.Sum();
        }
    }
}
