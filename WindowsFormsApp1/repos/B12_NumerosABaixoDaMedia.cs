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
    public partial class FormAtividade8 : Form
    {
        public FormAtividade8()
        {
            InitializeComponent();
        }

        List<double> numeros = new List<double>();
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Fazer o mesmo que a Atividade 11, mas fazendo a soma, media e dizendo a quantidade de números abaixo da média

            double somaTodos = numeros.Sum();
            double media = numeros.Average();
            int numeroInformado = int.Parse(txtNumero.Text);
            double nAbaixoMedia = numeros.Where(c => c < media).Count();

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
                MessageBox.Show("A soma de todos é " + somaTodos);
                MessageBox.Show("A media é " + media);
                MessageBox.Show("Números que não estão na media: " + nAbaixoMedia);
                btnAdicionar.Enabled = false;
            }
        }
    }
}
