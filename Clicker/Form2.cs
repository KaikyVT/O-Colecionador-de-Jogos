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
        private int _ValorUpgradeClick = 1000;
        private int _ValorUpgradeRoubarFita = 500;
        private int _ValorUpgradePiratear = 800;

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
            UpgradeClick.Text = $"Quebrar cofrinho ({_ValorUpgradeClick})";
            DescUpgradeClick.SetToolTip(UpgradeClick, "Aumenta o valor do seu click em 1");
            UpgradeRoubarAmigo.Text = $"Fazer mais amiguinhos ({_ValorUpgradeRoubarFita})";
            DescUpgradeRoubaFita.SetToolTip(UpgradeRoubarAmigo, "Aumenta a velocidade em que rouba os amigos");
            UpgradePiratear.Text = $"Ler mais One Piece ({_ValorUpgradePiratear})";
            DescUpgradePiratear.SetToolTip(UpgradePiratear, "Aumenta a velocidade em que pirateia a locadora");
        }

        public void AtualizarTexto() => NumJogos.Text = f.GetNumJogos().ToString();

        private void UpgradeClick_Click(object sender, EventArgs e)
        {
            if (f.GetNumJogos() >= _ValorUpgradeClick)
            {
                f.SetMultNumJogos(f.GetMultNumJogos() + 1);
                f.SetNumJogos(f.GetNumJogos() - _ValorUpgradeClick);
                f.AtualizaNumJogos();

                _ValorUpgradeClick += 1000; // aumenta o custo do próximo upgrade
                UpgradeClick.Text = $"Quebrar cofrinho ({_ValorUpgradeClick})";
            }
            else
            {
                MessageBox.Show("Você não tem jogos suficientes para comprar este upgrade.");
            }
        }

        private void UpgradeRoubarAmigo_Click(object sender, EventArgs e)
        {
            if (f.GetNumJogos() >= _ValorUpgradeRoubarFita)
            {
                if (f.GetMaxBarraRoubarFita() >= 10)
                {
                    f.SetNumJogos(f.GetNumJogos() - _ValorUpgradeRoubarFita);
                    _ValorUpgradeRoubarFita += 500;
                    f.SetMaxBarraRoubarFita(f.GetMaxBarraRoubarFita() - 2);
                    UpgradeRoubarAmigo.Text = $"Roubar Fita do amiguinho ({_ValorUpgradeRoubarFita})";
                }
                else
                {
                    MessageBox.Show("Você não pode mais melhorar isso.");
                }
            }
        }

        private void UpgradePiratear_Click(object sender, EventArgs e)
        {
            if (f.GetNumJogos() >= _ValorUpgradePiratear)
            {
                if (f.GetMaxBarraRoubarFita() >= 10)
                {
                    f.SetNumJogos(f.GetNumJogos() - _ValorUpgradePiratear);
                    _ValorUpgradePiratear += 500;
                    f.SetMaxBarraPiratearLocadora(f.GetMaxBarraPiratearLocadora() - 3);
                    UpgradePiratear.Text = $"Ler mais One Piece ({_ValorUpgradePiratear})";
                }
                else
                {
                    MessageBox.Show("Você não pode mais melhorar isso.");
                }
            }
        }
    }
}
