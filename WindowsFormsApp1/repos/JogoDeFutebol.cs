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
    public partial class JogoDeFutebol : Form
    {
        public JogoDeFutebol()
        {
            InitializeComponent();
        }

        int golTime1 = 0;
        int golTime2 = 0;

        private void btnConferir1_Click(object sender, EventArgs e)
        {
            if (txtTime1.Text == txtTime2.Text)
            {
                MessageBox.Show("Coloque o nome dos times corretamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            golTime1++;
            lblGolsTime1.Text = golTime1.ToString();
        }

        private void btnConferir2_Click(object sender, EventArgs e)
        {
            if (txtTime1.Text == txtTime2.Text)
            {
                MessageBox.Show("Coloque o nome dos times corretamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            golTime2++;
            lblGolsTime2.Text = golTime2.ToString();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            if (txtTime1.Text == txtTime2.Text)
            {
                MessageBox.Show("Coloque o nome dos times corretamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Você tem certeza?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(golTime1 > golTime2 ? txtTime1.Text + " venceu!" : golTime2 > golTime1 ? txtTime2.Text + " venceu!" : "EMPATE!", "Resultado");

                golTime1 = 0;
                golTime2 = 0;

                lblGolsTime1.Text = golTime1.ToString();
                lblGolsTime2.Text = golTime2.ToString();
            }
        }

        private void btnProcurar1_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFile = new OpenFileDialog();

            saveFile.InitialDirectory = "Desktop";
            saveFile.ShowDialog();

            pctTime1.ImageLocation = saveFile.FileName;
            pctTime1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnProcurar2_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFile = new OpenFileDialog();

            saveFile.InitialDirectory = "Desktop";
            saveFile.ShowDialog();

            pctTime2.ImageLocation = saveFile.FileName;
            pctTime2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnAnular1_Click(object sender, EventArgs e)
        {
            if (txtTime1.Text == txtTime2.Text)
            {
                MessageBox.Show("Coloque o nome dos times corretamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(golTime1 > 0)) return;

            golTime1--;
            lblGolsTime1.Text = golTime1.ToString();
        }

        private void btnAnular2_Click(object sender, EventArgs e)
        {
            if (txtTime1.Text == txtTime2.Text)
            {
                MessageBox.Show("Coloque o nome dos times corretamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(golTime2 > 0)) return;

            golTime2--;
            lblGolsTime2.Text = golTime2.ToString();
        }

    }
}

