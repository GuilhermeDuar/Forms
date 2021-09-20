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
    public partial class B10_Imprimir0a45 : Form
    {
        public B10_Imprimir0a45()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Imprime de 45 até 0

            List<int> numeros = new List<int>();
            string mensagem = "";

            for (int i = 45; i >= 0; i -= 3)
            {
                mensagem += i + Environment.NewLine;
            }

            MessageBox.Show(mensagem);
        }
    }
}
