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
    public partial class MaiorValorEntreDoisNumeros : Form
    {
        public MaiorValorEntreDoisNumeros()
        {
            InitializeComponent();
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtNum1.Text);
            int valor2 = int.Parse(txtNum2.Text);

            MessageBox.Show(valor1 > valor2 ? valor1.ToString() : valor2.ToString());
        }
    }
}
