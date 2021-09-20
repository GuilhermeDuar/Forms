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
    public partial class METODOHotel : Form
    {
        public METODOHotel()
        {
            InitializeComponent();
        }
        

        private void btnCalcularValorFinal_Click(object sender, EventArgs e)
        {
            double pessoas = double.Parse(txtNumeroDePessoas.Text);
            double dias = double.Parse(txtNumeroDeDias.Text);
            string quarto = "";

            if (rbStandart.Checked)
            {
                quarto = rbStandart.Text;
            }
            else if (rbLuxo.Checked)
            {
                quarto = rbLuxo.Text;
            }
            else
            {
                quarto = rbSuperLuxo.Text;
            }

            double preço = CalcularPreçoEstadia(quarto, pessoas, dias);
            lblPeçoFinal.Text = preço.ToString("C2");
            lblPeçoFinal.Visible = true;
        }

        double CalcularPreçoEstadia(string Quarto, double Pessoas, double Dias)
        {
            if (Quarto == "Standart" )
            {
                return Dias * Pessoas * 100;
            }
            if (Quarto == "Luxo")
            {
                return Dias * Pessoas * 200;
            }
            return Dias * Pessoas * 400;

            // Quarto passa a ser oque foi selecionado nas RadioButton e é comparado com as strings já escritas(standart, luxo...)
            // por ser uma RADIOBUTTON e só por isso, não é necessário compara o Quarto SuperLuxo com a String SUperLuxo
            // pois as RB sempre terão uma marcada e se nn foi nenhuma a cima, será a ultima

            // if (Quarto == "SuperLuxo")
            // {
            //    return Dias * Pessoas * 400;
            // }

            ///<summary>
            ///Método que converte String em um inteiro. Se a string estiver vazia, o resultado da conversão é ZERO.
            ///</summary>
            ///<param name="dado"> Valor a ser convertido para int</param>
            ///</returns>Resultado da conversão</returns>
            int ConverterParaInteiro(string dado)
            {
                if (dado == "")
                {
                    return 0;
                }
                return int.Parse(dado);
            }
            int pessoas = ConverterParaInteiro(txtNumeroDePessoas.Text);

           






        }
    }
}
