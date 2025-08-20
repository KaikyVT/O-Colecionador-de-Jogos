using System.Security.Cryptography.X509Certificates;

namespace Clicker
{
    public partial class Form1 : Form
    {
        private int _NumJogos = 10000;

        private int _ValorRoubarFita = 100;
        private int _MultRoubarFita = 0;
        private bool _RoubarFitaAtivo = false;

        private int _ValorPiratearLocadora = 500;
        private int _MultPiratearLocadora = 0;
        private bool _PiratearLocadoraAtivo = false;

        private int _ValorJogoDeepWeb = 1000;
        private int _MultJogoDeepWeb = 0;
        private bool _JogoDeepWebAtivo = false;

        public Form1()
        {
            InitializeComponent();
            NumJogos.Text = _NumJogos.ToString();

            RoubarFita.Text = $"Roubar Fita do amiguinho \n({_ValorRoubarFita} jogos)";
            ProgressoRoubaFita.Minimum = 0;
            ProgressoRoubaFita.Maximum = 100;
            ProgressoRoubaFita.Value = 0;
            PiratearLocadora.Text = $"Piratear cartucho da locadora \n({_ValorPiratearLocadora} jogos)";
            ProgressoPiratearLocadora.Minimum = 0;
            ProgressoPiratearLocadora.Maximum = 200;
            ProgressoPiratearLocadora.Value = 0;
            JogoDeepWeb.Text = $"Baixar jogo da Deep Web \n({_ValorJogoDeepWeb})";
            ProgressoJogoDeepWeb.Minimum = 0;
            ProgressoJogoDeepWeb.Maximum = 500;
            ProgressoJogoDeepWeb.Value = 0;


            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // 0,1s
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_RoubarFitaAtivo)
            {
                if (ProgressoRoubaFita.Value < ProgressoRoubaFita.Maximum)
                {
                    ProgressoRoubaFita.Value += 1; // avança
                }
                else
                {
                    _NumJogos += 10 * _MultRoubarFita;
                    NumJogos.Text = _NumJogos.ToString();
                    ProgressoRoubaFita.Value = 0; // reseta o progresso
                }
            }

            if (_PiratearLocadoraAtivo)
            {
                if (ProgressoPiratearLocadora.Value < ProgressoPiratearLocadora.Maximum)
                {
                    ProgressoPiratearLocadora.Value += 1; // avança
                }
                else
                {
                    _NumJogos += 50 * _MultPiratearLocadora;
                    NumJogos.Text = _NumJogos.ToString();
                    ProgressoPiratearLocadora.Value = 0; // reseta o progresso
                }
            }

            if (_JogoDeepWebAtivo)
            {
                if (ProgressoJogoDeepWeb.Value < ProgressoJogoDeepWeb.Maximum)
                {
                    ProgressoJogoDeepWeb.Value += 1; // avança
                }
                else
                {
                    _NumJogos += 200 * _MultJogoDeepWeb;
                    NumJogos.Text = _NumJogos.ToString();
                    ProgressoJogoDeepWeb.Value = 0; // reseta o progresso
                }
            }
        }

        private void CompraJogo_Click(object sender, EventArgs e)
        {
            _NumJogos += 1;
            NumJogos.Text = _NumJogos.ToString();
        }

        private void RoubarFita_Click(object sender, EventArgs e)
        {
            if (_NumJogos >= _ValorRoubarFita)
            {
                _MultRoubarFita += 1;
                _RoubarFitaAtivo = true;
                _NumJogos -= _ValorRoubarFita;
                NumJogos.Text = _NumJogos.ToString();
                _ValorRoubarFita += 50; // aumenta o valor para a próxima vez
                RoubarFita.Text = $"Roubar Fita do amiguinho \n({_ValorRoubarFita} jogos)";
            }
            else
            {
                MessageBox.Show($"Você precisa de pelo menos {_ValorRoubarFita} jogos para roubar a fita do amiguinho!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void PiratearLocadora_Click(object sender, EventArgs e)
        {
            if (_NumJogos >= _ValorPiratearLocadora)
            {
                _MultPiratearLocadora += 1;
                _PiratearLocadoraAtivo = true;
                _NumJogos -= _ValorPiratearLocadora;
                NumJogos.Text = _NumJogos.ToString();
                _ValorPiratearLocadora += 50; // aumenta o valor para a próxima vez
                PiratearLocadora.Text = $"Piratear cartucho da locadora \n({_ValorPiratearLocadora} jogos)";
            }
            else
            {
                MessageBox.Show($"Você precisa de pelo menos {_ValorPiratearLocadora} jogos para piratear cartucho da locadora!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void JogoDeepWeb_Click(object sender, EventArgs e)
        {
            if (_NumJogos >= _ValorJogoDeepWeb)
            {
                _MultJogoDeepWeb += 1;
                _JogoDeepWebAtivo = true;
                _NumJogos -= _ValorJogoDeepWeb;
                NumJogos.Text = _NumJogos.ToString();
                _ValorJogoDeepWeb += 200; // aumenta o valor para a próxima vez
                JogoDeepWeb.Text = $"Baixar jogo na Deep Web \n({_ValorJogoDeepWeb} jogos)";
            }
            else
            {
                MessageBox.Show($"Você precisa de pelo menos {_ValorJogoDeepWeb} jogos para Baixar Jogos da Deep Web!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
