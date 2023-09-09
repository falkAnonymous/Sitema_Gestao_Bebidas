namespace Quick_Drinks.ControleUsuario
{
    partial class Control_Produto
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Imagem = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Quantidade = new System.Windows.Forms.Label();
            this.lbl_Preco = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_Imagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Imagem
            // 
            this.panel_Imagem.BackColor = System.Drawing.Color.White;
            this.panel_Imagem.Controls.Add(this.pictureBox1);
            this.panel_Imagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Imagem.Location = new System.Drawing.Point(5, 0);
            this.panel_Imagem.Name = "panel_Imagem";
            this.panel_Imagem.Size = new System.Drawing.Size(190, 120);
            this.panel_Imagem.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.Location = new System.Drawing.Point(5, 123);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(93, 22);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_Quantidade
            // 
            this.lbl_Quantidade.Location = new System.Drawing.Point(88, 123);
            this.lbl_Quantidade.Name = "lbl_Quantidade";
            this.lbl_Quantidade.Size = new System.Drawing.Size(107, 22);
            this.lbl_Quantidade.TabIndex = 2;
            this.lbl_Quantidade.Text = "Quantidade";
            this.lbl_Quantidade.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Preco
            // 
            this.lbl_Preco.Location = new System.Drawing.Point(66, 159);
            this.lbl_Preco.Name = "lbl_Preco";
            this.lbl_Preco.Size = new System.Drawing.Size(58, 24);
            this.lbl_Preco.TabIndex = 3;
            this.lbl_Preco.Text = "Valor";
            this.lbl_Preco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 5);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(195, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 220);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 220);
            this.panel3.TabIndex = 6;
            // 
            // Control_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Preco);
            this.Controls.Add(this.lbl_Quantidade);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.panel_Imagem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Control_Produto";
            this.Size = new System.Drawing.Size(200, 220);
            this.panel_Imagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Imagem;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Quantidade;
        private System.Windows.Forms.Label lbl_Preco;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
