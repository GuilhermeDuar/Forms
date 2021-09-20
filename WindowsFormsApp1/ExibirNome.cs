using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ExibirNome : Form
    {
        public ExibirNome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox2.Text;
            string sobrenome = textBox3.Text;
            string alerta = "Cadastrado com sucesso, Sr(a) " + nome + " " + sobrenome;

            MessageBox.Show(alerta);
        }
    }
}
