namespace WinFormsApp9
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
            dgvProdutos = new DataGridView();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(68, 29);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowTemplate.Height = 25;
            dgvProdutos.Size = new Size(677, 214);
            dgvProdutos.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(68, 290);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(163, 76);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "ADICIONAR PRODUTO";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(582, 290);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(163, 76);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "EXCLUIR PRODUTO";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(325, 290);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(163, 76);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "EDITAR PRODUTO";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(dgvProdutos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProdutos;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnEditar;
    }
}