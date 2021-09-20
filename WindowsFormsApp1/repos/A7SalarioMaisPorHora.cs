using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace primeiro
{
    public partial class FormAtividade3 : Form
    {
        public FormAtividade3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Calcular o salário multiplicando o valor ganho por hora * Horas trabalhadas. Caso tenha horas extras, cada hora vale o dobro ganho p/hora.

            double ganhosPorHora = double.Parse(txtPorHora.Text);
            double horasTrabalhadas = double.Parse(txtHoras.Text);
            double horaExtra = double.Parse(txtHorasExtra.Text);
            double salario = ganhosPorHora * horasTrabalhadas;
            
            salario += (ganhosPorHora * horaExtra) * 2;

            MessageBox.Show("Salario de " + salario.ToString("C2"));
        }
    }
}
