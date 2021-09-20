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
    public partial class TrocarVariaveis : Form
    {
        public TrocarVariaveis()
        {
            InitializeComponent();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            int A = int.Parse(txt10.Text);
            int B = int.Parse(txt20.Text);
            int C = A;

            A = B;
            B = C;

            MessageBox.Show(A + " " + B);
        }
    }
}
