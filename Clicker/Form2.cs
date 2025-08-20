using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clicker
{
    public partial class Form2 : Form
    {

        Form1 f;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NumJogos.Text = f.GetNumJogos().ToString();
            DescUpgradeClick.SetToolTip(UpgradeClick, "Aumenta o valor do seu click em 1");
        }

        public void AtualizarTexto() => NumJogos.Text = f.GetNumJogos().ToString();

        private void UpgradeClick_Click(object sender, EventArgs e)
        {
            int a = f.GetNumJogos();
        }
    }
}
