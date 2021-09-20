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
    public partial class Atividade6 : Form
    {
        public Atividade6()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Caso os números informados sejam iguais, somamos. Caso contrário, multiplicamos.

            List<int> numeros = new List<int>();
            numeros.Add(int.Parse(txtNumero1.Text));
            numeros.Add(int.Parse(txtNumero2.Text));

            int resultado = 0;

            if (numeros[0] == numeros[1])
                resultado = numeros[0] + numeros[1];

            else
                resultado = numeros[0] * numeros[1];

            MessageBox.Show(resultado.ToString());
        }
    }
}
