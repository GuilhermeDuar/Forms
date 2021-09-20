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
    public partial class A3SalarioComissão : Form
    {
        public A3SalarioComissão()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calcular o salário de um vendedor + comissão. Caso a comissão ultrapasse os R$ 10,000, terá uma redução de 6% para impostos.

            double salarioBase = 1400;
            double comissao = double.Parse(textBox1.Text) * 0.03;
            double salario = salarioBase + comissao;

            if (comissao > 10000)
            {
                salario = salario * 0.94;
            }

            MessageBox.Show(salario.ToString("C2"));
        }
    }
}
