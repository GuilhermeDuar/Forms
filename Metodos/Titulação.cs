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
    public partial class Titulação : Form
    {
        public Titulação()
        {
            InitializeComponent();
        }

        string FormatarNomeTitulação(string nome, string titulaçao)
        {
            if (titulaçao.ToUpper() == "B")
            {
                return "Bachareal " + nome;
            }
            if (titulaçao.ToUpper() == "M")
            {
                return "Mestre " + nome;
            }
            if (titulaçao.ToUpper() == "E")
            {
                return "Especialista " + nome;
            }
            if (titulaçao.ToUpper() == "L")
            {
                return "Licenciado " + nome;
            }
            if (titulaçao.ToUpper() == "D")
            {
                return "Doutor " + nome;
            }
            return "Titulação não definida!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormatarNomeTitulação(textBox1.Text, textBox2.Text));
        }
    }
}
