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
    public partial class NumerosABaixoDaMedia : Form
    {
        public NumerosABaixoDaMedia()
        {
            InitializeComponent();
        }
        List<double> numeros = new List<double>();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdicionarNumeros(Convert.ToDouble(txtNumero.Text)));
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(PesquisarNumerosACimaDAMedia()));
        }


        string AdicionarNumeros(double numero)
        {
            numeros.Add(numero);
            return "Número adicionado com sucesso";
        }

        double PesquisarNumerosACimaDAMedia()
        {
            double media = numeros.Average();

            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] > media)
                {
                    return numeros.Where(c => c > media).Count();
                }
            }
            return 0;
        }
        //     double soma = 0;
        //     for (int i = 0; i < numeros.Count; i++)
        //          {
        //               soma += numeros[i]
        //          }

    }
}
