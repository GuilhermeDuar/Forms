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
    public partial class VerificarTriangulo : Form
    {
        public VerificarTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtLadoA.Text == "" || txtLadoB.Text == "" || txtLadoC.Text =="")
            {
                MessageBox.Show("Inserir valores");
                return;
            }

            int l1 = int.Parse(txtLadoA.Text);
            int l2 = int.Parse(txtLadoB.Text);
            int l3 = int.Parse(txtLadoC.Text);

            // bool ehTiangulo = VerificarintegridadeTriangulo(l1, l2, l3);

            if (VerificarintegridadeTriangulo(l1, l2, l3))
            {
                string tipo = CalcularTipotriangulo(l1, l2, l3);
                MessageBox.Show(tipo);
            }
            else
            {
                MessageBox.Show("Os lados não formam um triângulo");
            }
        }

        bool VerificarintegridadeTriangulo(int lado1, int lado2, int lado3)
        {
            // return !(lado1 > lado2 + lado3 || lado2 > lado1 + lado3 || lado3 > lado1 + lado2);


            if (lado1 > lado2 + lado3 || lado2 > lado1 + lado3 || lado3 > lado1 + lado2)
            {
                return false;  // retorna false pois é um bool
            }
            return true;
        }

        string CalcularTipotriangulo( int lado1, int lado2, int lado3)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return "Equilátero";
            }
            if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return "Isósceles";
            }
            return "Escaleno";
        }

       
    }
}
