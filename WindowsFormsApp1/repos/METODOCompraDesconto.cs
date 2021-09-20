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
    public partial class METODOCompraDesconto : Form
    {
        public METODOCompraDesconto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double preço = double.Parse(txtValorAPagar.Text);
            string pagamento = "";

            if (rbAvista.Checked)
            {
                pagamento = "À vista";
            }
            else
            {
                pagamento = "Parcelado";
            }
            double preçoFinal = CalcularDesconto(preço, pagamento);
            MessageBox.Show(preçoFinal.ToString("C2"));
        }

        double CalcularDesconto(double ValorCompra, string pagamento)
        {
            if (ValorCompra > 1000)
            {
                ValorCompra = ValorCompra * 0.88;
            }
            if (pagamento == "À vista")
            {
               return ValorCompra * 0.94;
            }
            return ValorCompra;
        }





    }
}
