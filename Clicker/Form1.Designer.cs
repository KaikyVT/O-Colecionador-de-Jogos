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
            Jogos.Location = new Point(276, 7);
            Jogos.Name = "Jogos";
            Jogos.Size = new Size(71, 28);
            Jogos.TabIndex = 0;
            Jogos.Text = "Jogos:";
            // 
            // NumJogos
            // 
            NumJogos.AutoSize = true;
            NumJogos.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NumJogos.Location = new Point(359, 7);
            NumJogos.Name = "NumJogos";
            NumJogos.Size = new Size(24, 28);
            NumJogos.TabIndex = 1;
            NumJogos.Text = "0";
            // 
            // CompraJogo
            // 
            CompraJogo.Location = new Point(303, 55);
            CompraJogo.Margin = new Padding(3, 2, 3, 2);
            CompraJogo.Name = "CompraJogo";
            CompraJogo.Size = new Size(66, 50);
            CompraJogo.TabIndex = 2;
            CompraJogo.Text = "Comprar Fita";
            CompraJogo.UseVisualStyleBackColor = true;
            CompraJogo.Click += CompraJogo_Click;
            // 
            // RoubarFita
            // 
            RoubarFita.Location = new Point(10, 123);
            RoubarFita.Margin = new Padding(3, 2, 3, 2);
            RoubarFita.Name = "RoubarFita";
            RoubarFita.Size = new Size(124, 72);
            RoubarFita.TabIndex = 3;
            RoubarFita.Text = "Roubar fita do amiguinho";
            RoubarFita.UseVisualStyleBackColor = true;
            RoubarFita.Click += RoubarFita_Click;
            // 
            // ProgressoRoubaFita
            // 
            ProgressoRoubaFita.Location = new Point(10, 208);
            ProgressoRoubaFita.Margin = new Padding(3, 2, 3, 2);
            ProgressoRoubaFita.Name = "ProgressoRoubaFita";
            ProgressoRoubaFita.Size = new Size(124, 22);
            ProgressoRoubaFita.TabIndex = 4;
            // 
            // ProgressoPiratearLocadora
            // 
            ProgressoPiratearLocadora.Location = new Point(171, 208);
            ProgressoPiratearLocadora.Margin = new Padding(3, 2, 3, 2);
            ProgressoPiratearLocadora.Name = "ProgressoPiratearLocadora";
            ProgressoPiratearLocadora.Size = new Size(124, 22);
            ProgressoPiratearLocadora.TabIndex = 6;
            // 
            // PiratearLocadora
            // 
            PiratearLocadora.Location = new Point(171, 123);
            PiratearLocadora.Margin = new Padding(3, 2, 3, 2);
            PiratearLocadora.Name = "PiratearLocadora";
            PiratearLocadora.Size = new Size(124, 72);
            PiratearLocadora.TabIndex = 5;
            PiratearLocadora.Text = "Piratear cartucho da locadora";
            PiratearLocadora.UseVisualStyleBackColor = true;
            PiratearLocadora.Click += PiratearLocadora_Click;
            // 
            // ProgressoJogoDeepWeb
            // 
            ProgressoJogoDeepWeb.Location = new Point(339, 208);
            ProgressoJogoDeepWeb.Margin = new Padding(3, 2, 3, 2);
            ProgressoJogoDeepWeb.Name = "ProgressoJogoDeepWeb";
            ProgressoJogoDeepWeb.Size = new Size(124, 22);
            ProgressoJogoDeepWeb.TabIndex = 8;
            // 
            // JogoDeepWeb
            // 
            JogoDeepWeb.Location = new Point(339, 123);
            JogoDeepWeb.Margin = new Padding(3, 2, 3, 2);
            JogoDeepWeb.Name = "JogoDeepWeb";
            JogoDeepWeb.Size = new Size(124, 72);
            JogoDeepWeb.TabIndex = 7;
            JogoDeepWeb.Text = "Baixar Jogos da Deep Web";
            JogoDeepWeb.UseVisualStyleBackColor = true;
            JogoDeepWeb.Click += JogoDeepWeb_Click;
            // 
            // Loja
            // 
            Loja.Location = new Point(603, 36);
            Loja.Name = "Loja";
            Loja.Size = new Size(75, 23);
            Loja.TabIndex = 9;
            Loja.Text = "Loja";
            Loja.UseVisualStyleBackColor = true;
            Loja.Click += Loja_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 632);
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
            Margin = new Padding(3, 2, 3, 2);
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
