namespace CadastroDeAnimais.View
{
    partial class TelaCadastroAnimais
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbx_Porte = new ComboBox();
            label4 = new Label();
            tbx_name = new TextBox();
            tbx_Raca = new TextBox();
            btn_Cadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 38);
            label1.Name = "label1";
            label1.Size = new Size(299, 40);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Animais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(74, 132);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(82, 181);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Raça:";
            // 
            // cbx_Porte
            // 
            cbx_Porte.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            cbx_Porte.FormattingEnabled = true;
            cbx_Porte.Items.AddRange(new object[] { "Pequeno", "Médio", "Grande", "Gigante" });
            cbx_Porte.Location = new Point(151, 230);
            cbx_Porte.Name = "cbx_Porte";
            cbx_Porte.Size = new Size(147, 33);
            cbx_Porte.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(74, 238);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 4;
            label4.Text = "Porte:";
            // 
            // tbx_name
            // 
            tbx_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbx_name.Location = new Point(151, 132);
            tbx_name.Name = "tbx_name";
            tbx_name.Size = new Size(271, 33);
            tbx_name.TabIndex = 5;
            // 
            // tbx_Raca
            // 
            tbx_Raca.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbx_Raca.Location = new Point(151, 173);
            tbx_Raca.Name = "tbx_Raca";
            tbx_Raca.Size = new Size(147, 33);
            tbx_Raca.TabIndex = 6;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Location = new Point(40, 296);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(455, 41);
            btn_Cadastrar.TabIndex = 7;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // TelaCadastroAnimais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 376);
            Controls.Add(btn_Cadastrar);
            Controls.Add(tbx_Raca);
            Controls.Add(tbx_name);
            Controls.Add(label4);
            Controls.Add(cbx_Porte);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaCadastroAnimais";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Cadastro de Animais:::";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbx_Porte;
        private Label label4;
        private TextBox tbx_name;
        private TextBox tbx_Raca;
        private Button btn_Cadastrar;
    }
}