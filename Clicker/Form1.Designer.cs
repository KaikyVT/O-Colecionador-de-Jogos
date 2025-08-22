namespace Clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Jogos = new Label();
            NumJogos = new Label();
            CompraJogo = new Button();
            RoubarFita = new Button();
            ProgressoRoubaFita = new ProgressBar();
            ProgressoPiratearLocadora = new ProgressBar();
            PiratearLocadora = new Button();
            ProgressoJogoDeepWeb = new ProgressBar();
            JogoDeepWeb = new Button();
            Loja = new Button();
            SuspendLayout();
            // 
            // Jogos
            // 
            Jogos.AutoSize = true;
            Jogos.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Jogos.Location = new Point(315, 9);
            Jogos.Name = "Jogos";
            Jogos.Size = new Size(89, 35);
            Jogos.TabIndex = 0;
            Jogos.Text = "Jogos:";
            // 
            // NumJogos
            // 
            NumJogos.AutoSize = true;
            NumJogos.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NumJogos.Location = new Point(410, 9);
            NumJogos.Name = "NumJogos";
            NumJogos.Size = new Size(29, 35);
            NumJogos.TabIndex = 1;
            NumJogos.Text = "0";
            // 
            // CompraJogo
            // 
            CompraJogo.Location = new Point(346, 73);
            CompraJogo.Name = "CompraJogo";
            CompraJogo.Size = new Size(75, 67);
            CompraJogo.TabIndex = 2;
            CompraJogo.Text = "Comprar Fita";
            CompraJogo.UseVisualStyleBackColor = true;
            CompraJogo.Click += CompraJogo_Click;
            // 
            // RoubarFita
            // 
            RoubarFita.Location = new Point(11, 164);
            RoubarFita.Name = "RoubarFita";
            RoubarFita.Size = new Size(142, 96);
            RoubarFita.TabIndex = 3;
            RoubarFita.Text = "Roubar fita do amiguinho";
            RoubarFita.UseVisualStyleBackColor = true;
            RoubarFita.Click += RoubarFita_Click;
            // 
            // ProgressoRoubaFita
            // 
            ProgressoRoubaFita.Location = new Point(11, 277);
            ProgressoRoubaFita.Name = "ProgressoRoubaFita";
            ProgressoRoubaFita.Size = new Size(142, 29);
            ProgressoRoubaFita.TabIndex = 4;
            // 
            // ProgressoPiratearLocadora
            // 
            ProgressoPiratearLocadora.Location = new Point(195, 277);
            ProgressoPiratearLocadora.Name = "ProgressoPiratearLocadora";
            ProgressoPiratearLocadora.Size = new Size(142, 29);
            ProgressoPiratearLocadora.TabIndex = 6;
            // 
            // PiratearLocadora
            // 
            PiratearLocadora.Location = new Point(195, 164);
            PiratearLocadora.Name = "PiratearLocadora";
            PiratearLocadora.Size = new Size(142, 96);
            PiratearLocadora.TabIndex = 5;
            PiratearLocadora.Text = "Piratear cartucho da locadora";
            PiratearLocadora.UseVisualStyleBackColor = true;
            PiratearLocadora.Click += PiratearLocadora_Click;
            // 
            // ProgressoJogoDeepWeb
            // 
            ProgressoJogoDeepWeb.Location = new Point(387, 277);
            ProgressoJogoDeepWeb.Name = "ProgressoJogoDeepWeb";
            ProgressoJogoDeepWeb.Size = new Size(142, 29);
            ProgressoJogoDeepWeb.TabIndex = 8;
            // 
            // JogoDeepWeb
            // 
            JogoDeepWeb.Location = new Point(387, 164);
            JogoDeepWeb.Name = "JogoDeepWeb";
            JogoDeepWeb.Size = new Size(142, 96);
            JogoDeepWeb.TabIndex = 7;
            JogoDeepWeb.Text = "Baixar Jogos da Deep Web";
            JogoDeepWeb.UseVisualStyleBackColor = true;
            JogoDeepWeb.Click += JogoDeepWeb_Click;
            // 
            // Loja
            // 
            Loja.Location = new Point(689, 48);
            Loja.Margin = new Padding(3, 4, 3, 4);
            Loja.Name = "Loja";
            Loja.Size = new Size(86, 31);
            Loja.TabIndex = 9;
            Loja.Text = "Loja";
            Loja.UseVisualStyleBackColor = true;
            Loja.Click += Loja_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 843);
            Controls.Add(Loja);
            Controls.Add(ProgressoJogoDeepWeb);
            Controls.Add(JogoDeepWeb);
            Controls.Add(ProgressoPiratearLocadora);
            Controls.Add(PiratearLocadora);
            Controls.Add(ProgressoRoubaFita);
            Controls.Add(RoubarFita);
            Controls.Add(CompraJogo);
            Controls.Add(NumJogos);
            Controls.Add(Jogos);
            Name = "Form1";
            Text = "Colecionador de Jogos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Jogos;
        private Label NumJogos;
        private Button CompraJogo;
        private Button RoubarFita;
        private ProgressBar ProgressoRoubaFita;
        private ProgressBar ProgressoPiratearLocadora;
        private Button PiratearLocadora;
        private ProgressBar ProgressoJogoDeepWeb;
        private Button JogoDeepWeb;
        private Button Loja;
    }
}
