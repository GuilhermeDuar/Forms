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
    public partial class TrianguloCirculoQuadrado : Form
    {
        public TrianguloCirculoQuadrado()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SalectedIndex é a posição na comboBox
            if (comboBox1.SelectedIndex == 0)
            {
                panel1.Visible = true;
                panel1.Location = new System.Drawing.Point(200, 90);
                panel2.Visible = false;
                panel3.Visible = false;
                txtAltura.Clear();
                txtBase.Clear();
                txtLado1.Clear();
                txtLado2.Clear();
                lblResultadoTriângulo.Text = "";
                lblResultadoQuadrado.Text = "";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel2.Location = new System.Drawing.Point(200, 90);
                panel3.Visible = false;
                txtRaio.Clear();
                txtLado1.Clear();
                txtLado2.Clear();
                lblResultadoQuadrado.Text = "";
                lblResultadoCirculo.Text = "";
            }
            else
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
                panel3.Location = new System.Drawing.Point(200, 90);
                txtRaio.Clear();
                txtAltura.Clear();
                txtBase.Clear();
                lblResultadoCirculo.Text = "";
                lblResultadoTriângulo.Text = "";

            }
        }
        private void btnCalculoCirculo_Click(object sender, EventArgs e)
        {
            double raio = double.Parse(txtRaio.Text);

            lblResultadoCirculo.Text = CalcularAreaCirculo(raio);
            lblResultadoCirculo.Visible = true;
        }

        private void btnCalcularQuadrado_Click(object sender, EventArgs e)
        {
            double lado1 = double.Parse(txtLado1.Text);
            double lado2 = double.Parse(txtLado2.Text);

            lblResultadoQuadrado.Text = CalcularAreaQuadrado(lado1, lado2);
            lblResultadoQuadrado.Visible = true;
        }

        private void btnCalcularTrângulo_Click(object sender, EventArgs e)
        {
           
            double altura = double.Parse(txtAltura.Text);
            double @base = double.Parse(txtBase.Text);

            lblResultadoTriângulo.Text = CalcularAreaTriangulo(altura,@base);
            lblResultadoTriângulo.Visible = true;
        }

        // Metodos criados para calculos
        string  CalcularAreaTriangulo( double h, double b)
        {
            if (h == 0 || b == 0)
            {
                return "Favor insira ambos os dados.";
            }
            double calculo = (h * b) / 2;
            return calculo.ToString("N2");
        }

        string CalcularAreaQuadrado(double l1, double l2)
        {
            if (l1 == 0 || l2 == 0)
            {
               return "Favor insira ambos os lados.";
            }
            double calculo = l1 * l2;
            return calculo.ToString("N2");
        }

        string CalcularAreaCirculo( double r)
        {
            if (r == 0)
            {
                return "Favor insira um raio.";
            }
            double pi = 3.14;
            double calculo = pi * Math.Pow(r, 2);
            return calculo.ToString("N2");
        }
    }
}
