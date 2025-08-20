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
            SuspendLayout();
            // 
            // UpgradeClick
            // 
            UpgradeClick.Location = new Point(72, 93);
            UpgradeClick.Name = "UpgradeClick";
            UpgradeClick.Size = new Size(105, 57);
            UpgradeClick.TabIndex = 0;
            UpgradeClick.Text = "Quebrar cofrinho";
            UpgradeClick.UseVisualStyleBackColor = true;
            UpgradeClick.Click += UpgradeClick_Click;
            // 
            // NumJogos
            // 
            NumJogos.AutoSize = true;
            NumJogos.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NumJogos.Location = new Point(405, 9);
            NumJogos.Name = "NumJogos";
            NumJogos.Size = new Size(24, 28);
            NumJogos.TabIndex = 3;
            NumJogos.Text = "0";
            // 
            // Jogos
            // 
            Jogos.AutoSize = true;
            Jogos.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Jogos.Location = new Point(322, 9);
            Jogos.Name = "Jogos";
            Jogos.Size = new Size(71, 28);
            Jogos.TabIndex = 2;
            Jogos.Text = "Jogos:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NumJogos);
            Controls.Add(Jogos);
            Controls.Add(UpgradeClick);
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
    }
}