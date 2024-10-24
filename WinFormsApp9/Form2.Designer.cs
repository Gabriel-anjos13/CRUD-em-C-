namespace WinFormsApp9
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
            txtNome = new TextBox();
            txtPreco = new TextBox();
            lblNome = new Label();
            lblPreco = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(251, 80);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(287, 23);
            txtNome.TabIndex = 0;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(251, 154);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(287, 23);
            txtPreco.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(130, 80);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 28);
            lblNome.TabIndex = 2;
            lblNome.Text = "NOME";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPreco.Location = new Point(130, 149);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(71, 28);
            lblPreco.TabIndex = 3;
            lblPreco.Text = "PREÇO";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(251, 266);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(287, 83);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(lblPreco);
            Controls.Add(lblNome);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPreco;
        private Label lblNome;
        private Label lblPreco;
        private Button btnSalvar;
    }
}