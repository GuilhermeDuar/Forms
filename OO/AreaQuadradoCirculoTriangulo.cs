using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO
{
    public partial class AreaQuadradoCirculoTriangulo : Form
    {
        public AreaQuadradoCirculoTriangulo()
        {
            InitializeComponent();
        }
        Quadrado q = new Quadrado();
        Triangulo t = new Triangulo();

        private void btnCalcularQuadrado_Click(object sender, EventArgs e)
        {
            q.AreaQuadrado = Quadrado.CalcularAreaQuadrado(double.Parse(txtLado1.Text), double.Parse(txtLado2.Text));
            q.PerimetroQuadrado = Quadrado.CalcularPerimetroQuadrado(double.Parse(txtLado1.Text), double.Parse(txtLado2.Text));
            MessageBox.Show(q.ToString());
        }

        private void btnCalculoTriangulo_Click(object sender, EventArgs e)
        {
            t.AreaTriangulo = Triangulo.CalcularArea(double.Parse(txtLadoTriangulo1.Text), double.Parse(txtLadoTriangulo2.Text), double.Parse(txtBaseTriangulo.Text));
            t.PerimetroTriangulo = Triangulo.CalcularPerimetro(double.Parse(txtLadoTriangulo1.Text), double.Parse(txtLadoTriangulo2.Text), double.Parse(txtBaseTriangulo.Text));
            t.AlturaTriangulo = Triangulo.CalcularAltura(t.AreaTriangulo, double.Parse(txtBaseTriangulo.Text));

            MessageBox.Show(t.ToString());
        }
    }
}
