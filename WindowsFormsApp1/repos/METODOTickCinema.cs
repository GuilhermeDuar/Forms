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
    public partial class METODOTickCinema : Form
    {
        public METODOTickCinema()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int idade = int.Parse(txtIdade.Text);
            bool vip = cbVip.Checked;
            double tempo = double.Parse(txtTempo.Text);

            double preçoFinal = preçoCinema(idade, vip, tempo);
            MessageBox.Show(preçoFinal.ToString());
        }

        double preçoCinema(int idade, bool Vip, double tempo)
        {
            double tick = 50;

            if (idade < 18)
            {
                tick = tick - 5;
            }
            if (Vip)
            {
                tick = tick + 12;
            }
            return tick + (tempo * 5);
        }

        
       
         



    }
}
