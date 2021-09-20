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
            string tipoDeTriangulo = "";
            double ladoA = int.Parse(txtLadoA.Text);
            double ladoB = int.Parse(txtLadoB.Text);
            double ladoC = int.Parse(txtLadoC.Text);

            if (ladoA > ladoB + ladoC || ladoB > ladoA + ladoC || ladoC > ladoB + ladoA)
            {
                MessageBox.Show("Não é um triangulo");
                return;
            }

            if (ladoA == ladoB && ladoA == ladoC)
                tipoDeTriangulo = "Equilátero";
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                tipoDeTriangulo = "Isósceles";
            else
                tipoDeTriangulo = "Escaleno";

            MessageBox.Show("O seu triangulo é um " + tipoDeTriangulo);
        }
    }
}
