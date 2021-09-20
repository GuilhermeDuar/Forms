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
    public partial class FormAtividade5 : Form
    {
        public FormAtividade5()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            //Imprimir apenas números pares

            List<int> numeros = new List<int>();
            string mensagem = "";

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    numeros.Add(i);
                }
            }

            for (int i = 0; i < numeros.Count; i++)
            {
                mensagem += numeros[i] + Environment.NewLine;
            }

            MessageBox.Show(mensagem);
        }
    }
}
