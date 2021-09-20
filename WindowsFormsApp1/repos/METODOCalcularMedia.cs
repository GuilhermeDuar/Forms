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
    public partial class METODOCalcularMedia : Form
    {
        public METODOCalcularMedia()
        {
            InitializeComponent();
        }

        private void btnGerarMedia_Click_1(object sender, EventArgs e)
        {
            if (txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "")
            {
                MessageBox.Show("Adicione as notas!");
                return;
            }
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota2.Text);
            double nota3 = double.Parse(txtNota3.Text);

            string final = CalcularMedia(nota1, nota2, nota3);
            MessageBox.Show(final);
        }

        string CalcularMedia(double nota1, double nota2, double nota3)
        {
            double calculo = (nota1 + nota2 + nota3) / 3;
            if (calculo < 5)
            {
                return "reprovado";
            }

            else if (calculo < 7)
            {
                return "Você esta de recuperação";
            }
            else
            {
                return "Você está aprovado!";
            }

        }

    }
}
