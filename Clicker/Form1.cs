using System.Security.Cryptography.X509Certificates;

namespace Clicker
{
    public partial class Form1 : Form
    {
        Form2 f;

        private int _NumJogos = 1000000;
        public int GetNumJogos() => _NumJogos;
        public void SetNumJogos(int numJogos)
        {
            _NumJogos = numJogos;
            AtualizaNumJogos();
        }
        private int _MultNumJogos = 1;
        public int GetMultNumJogos() => _MultNumJogos;
        public void SetMultNumJogos(int multNumJogos)
        {
            _MultNumJogos = multNumJogos;
            AtualizaNumJogos();
        }
        private int _ValorRoubarFita = 100;
        private int _MultRoubarFita = 0;
        private bool _RoubarFitaAtivo = false;
        private int _MaxBarraRoubarFita = 100;
        public int GetMaxBarraRoubarFita() => _MaxBarraRoubarFita;
        public void SetMaxBarraRoubarFita(int maxBarraRoubarFita)
        {
            _MaxBarraRoubarFita = maxBarraRoubarFita;
            ProgressoRoubaFita.Maximum = _MaxBarraRoubarFita;
        }

        private int _ValorPiratearLocadora = 500;
        private int _MultPiratearLocadora = 0;
        private bool _PiratearLocadoraAtivo = false;
        private int _MaxBarraPiratearLocadora = 200;
        public int GetMaxBarraPiratearLocadora() => _MaxBarraPiratearLocadora;
        public void SetMaxBarraPiratearLocadora(int maxBarraPiratearLocadora)
        {
            _MaxBarraPiratearLocadora = maxBarraPiratearLocadora;
            ProgressoPiratearLocadora.Maximum = _MaxBarraPiratearLocadora;
        }

        private int _ValorJogoDeepWeb = 1000;
        private int _MultJogoDeepWeb = 0;
        private bool _JogoDeepWebAtivo = false;
        private int _MaxBarraJogoDeepWeb = 500;
        public int GetMaxBarraJogoDeepWeb() => _MaxBarraJogoDeepWeb;
        public void SetMaxBarraJogoDeepWeb(int maxBarraJogoDeepWeb)
        {
            _MaxBarraJogoDeepWeb = maxBarraJogoDeepWeb;
            ProgressoJogoDeepWeb.Maximum = _MaxBarraJogoDeepWeb;
        }

        public Form1()
        {
            InitializeComponent();
            NumJogos.Text = _NumJogos.ToString();
            f = new(this);
            f.AtualizarTexto();
            RoubarFita.Text = $"Roubar Fita do amiguinho \n({_ValorRoubarFita} jogos)";
            ProgressoRoubaFita.Minimum = 0;
            ProgressoRoubaFita.Maximum = _MaxBarraRoubarFita;
            ProgressoRoubaFita.Value = 0;
            PiratearLocadora.Text = $"Piratear cartucho da locadora \n({_ValorPiratearLocadora} jogos)";
            ProgressoPiratearLocadora.Minimum = 0;
            ProgressoPiratearLocadora.Maximum = _MaxBarraPiratearLocadora;
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

        public void AtualizaNumJogos()
        {
            NumJogos.Text = _NumJogos.ToString();
            if (f != null && !f.IsDisposed)
            {
                f.AtualizarTexto();
            }
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
                    AtualizaNumJogos();
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
                    _NumJogos += 70 * _MultPiratearLocadora;
                    AtualizaNumJogos();
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
                    _NumJogos += 150 * _MultJogoDeepWeb;
                    AtualizaNumJogos();
                    ProgressoJogoDeepWeb.Value = 0; // reseta o progresso
                }
            }
        }

        private void CompraJogo_Click(object sender, EventArgs e)
        {
            _NumJogos += 1 * _MultNumJogos;
            AtualizaNumJogos();
        }

        private void RoubarFita_Click(object sender, EventArgs e)
        {
            if (_NumJogos >= _ValorRoubarFita)
            {
                _MultRoubarFita += 1;
                _RoubarFitaAtivo = true;
                _NumJogos -= _ValorRoubarFita;
                AtualizaNumJogos();
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
                AtualizaNumJogos();
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
                AtualizaNumJogos();
                _ValorJogoDeepWeb += 200; // aumenta o valor para a próxima vez
                JogoDeepWeb.Text = $"Baixar jogo na Deep Web \n({_ValorJogoDeepWeb} jogos)";
            }
            else
            {
                MessageBox.Show($"Você precisa de pelo menos {_ValorJogoDeepWeb} jogos para Baixar Jogos da Deep Web!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Loja_Click(object sender, EventArgs e)
        {
            f = new Form2(this);
            f.Show();
        }

       
    }
}
