namespace Clicker
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            UpgradeClick = new Button();
            DescUpgradeClick = new ToolTip(components);
            NumJogos = new Label();
            Jogos = new Label();
            UpgradeRoubarAmigo = new Button();
            DescUpgradeRoubaFita = new ToolTip(components);
            UpgradePiratear = new Button();
            DescUpgradePiratear = new ToolTip(components);
            SuspendLayout();
            // 
            // UpgradeClick
            // 
            UpgradeClick.Location = new Point(82, 124);
            UpgradeClick.Margin = new Padding(3, 4, 3, 4);
            UpgradeClick.Name = "UpgradeClick";
            UpgradeClick.Size = new Size(120, 76);
            UpgradeClick.TabIndex = 0;
            UpgradeClick.Text = "Quebrar cofrinho";
            UpgradeClick.UseVisualStyleBackColor = true;
            UpgradeClick.Click += UpgradeClick_Click;
            // 
            // NumJogos
            // 
            NumJogos.AutoSize = true;
            NumJogos.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NumJogos.Location = new Point(463, 12);
            NumJogos.Name = "NumJogos";
            NumJogos.Size = new Size(29, 35);
            NumJogos.TabIndex = 3;
            NumJogos.Text = "0";
            // 
            // Jogos
            // 
            Jogos.AutoSize = true;
            Jogos.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Jogos.Location = new Point(368, 12);
            Jogos.Name = "Jogos";
            Jogos.Size = new Size(89, 35);
            Jogos.TabIndex = 2;
            Jogos.Text = "Jogos:";
            // 
            // UpgradeRoubarAmigo
            // 
            UpgradeRoubarAmigo.Location = new Point(242, 124);
            UpgradeRoubarAmigo.Margin = new Padding(3, 4, 3, 4);
            UpgradeRoubarAmigo.Name = "UpgradeRoubarAmigo";
            UpgradeRoubarAmigo.Size = new Size(120, 76);
            UpgradeRoubarAmigo.TabIndex = 4;
            UpgradeRoubarAmigo.Text = "Fazer mais amiguinhos";
            UpgradeRoubarAmigo.UseVisualStyleBackColor = true;
            UpgradeRoubarAmigo.Click += UpgradeRoubarAmigo_Click;
            // 
            // UpgradePiratear
            // 
            UpgradePiratear.Location = new Point(404, 124);
            UpgradePiratear.Margin = new Padding(3, 4, 3, 4);
            UpgradePiratear.Name = "UpgradePiratear";
            UpgradePiratear.Size = new Size(120, 76);
            UpgradePiratear.TabIndex = 5;
            UpgradePiratear.Text = "Ler mais One Piece";
            UpgradePiratear.UseVisualStyleBackColor = true;
            UpgradePiratear.Click += UpgradePiratear_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(UpgradePiratear);
            Controls.Add(UpgradeRoubarAmigo);
            Controls.Add(NumJogos);
            Controls.Add(Jogos);
            Controls.Add(UpgradeClick);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Loja de Upgrades";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpgradeClick;
        private ToolTip DescUpgradeClick;
        private Label NumJogos;
        private Label Jogos;
        private Button UpgradeRoubarAmigo;
        private ToolTip DescUpgradeRoubaFita;
        private Button UpgradePiratear;
        private ToolTip DescUpgradePiratear;
    }
}