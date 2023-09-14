namespace Quick_Drinks.Janelas.PastProduto.CadastroProduto
{
    partial class Cadastro_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Produto));
            this.cadastropanel = new System.Windows.Forms.Panel();
            this.box_PrecoProduto = new System.Windows.Forms.TextBox();
            this.lbl_NomeFoto = new System.Windows.Forms.Label();
            this.btn_SairProduto = new Guna.UI.WinForms.GunaButton();
            this.btn_ConfirmarProduto = new Guna.UI.WinForms.GunaButton();
            this.numeroQuantidadeProduto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.box_NomeProduto = new System.Windows.Forms.TextBox();
            this.imagem_Produto = new System.Windows.Forms.PictureBox();
            this.cadastropanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroQuantidadeProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem_Produto)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastropanel
            // 
            this.cadastropanel.Controls.Add(this.box_PrecoProduto);
            this.cadastropanel.Controls.Add(this.lbl_NomeFoto);
            this.cadastropanel.Controls.Add(this.btn_SairProduto);
            this.cadastropanel.Controls.Add(this.btn_ConfirmarProduto);
            this.cadastropanel.Controls.Add(this.numeroQuantidadeProduto);
            this.cadastropanel.Controls.Add(this.label3);
            this.cadastropanel.Controls.Add(this.label2);
            this.cadastropanel.Controls.Add(this.label1);
            this.cadastropanel.Controls.Add(this.box_NomeProduto);
            this.cadastropanel.Controls.Add(this.imagem_Produto);
            this.cadastropanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastropanel.Location = new System.Drawing.Point(0, 0);
            this.cadastropanel.Name = "cadastropanel";
            this.cadastropanel.Size = new System.Drawing.Size(378, 380);
            this.cadastropanel.TabIndex = 0;
            // 
            // box_PrecoProduto
            // 
            this.box_PrecoProduto.Location = new System.Drawing.Point(87, 291);
            this.box_PrecoProduto.Name = "box_PrecoProduto";
            this.box_PrecoProduto.Size = new System.Drawing.Size(124, 20);
            this.box_PrecoProduto.TabIndex = 12;
            this.box_PrecoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbl_NomeFoto
            // 
            this.lbl_NomeFoto.AutoSize = true;
            this.lbl_NomeFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeFoto.Location = new System.Drawing.Point(163, 173);
            this.lbl_NomeFoto.Name = "lbl_NomeFoto";
            this.lbl_NomeFoto.Size = new System.Drawing.Size(48, 24);
            this.lbl_NomeFoto.TabIndex = 1;
            this.lbl_NomeFoto.Text = "Foto";
            // 
            // btn_SairProduto
            // 
            this.btn_SairProduto.AnimationHoverSpeed = 0.07F;
            this.btn_SairProduto.AnimationSpeed = 0.03F;
            this.btn_SairProduto.BackColor = System.Drawing.Color.Transparent;
            this.btn_SairProduto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_SairProduto.BorderColor = System.Drawing.Color.Black;
            this.btn_SairProduto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_SairProduto.FocusedColor = System.Drawing.Color.Empty;
            this.btn_SairProduto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_SairProduto.ForeColor = System.Drawing.Color.White;
            this.btn_SairProduto.Image = null;
            this.btn_SairProduto.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_SairProduto.Location = new System.Drawing.Point(20, 326);
            this.btn_SairProduto.Name = "btn_SairProduto";
            this.btn_SairProduto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_SairProduto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_SairProduto.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_SairProduto.OnHoverImage = null;
            this.btn_SairProduto.OnPressedColor = System.Drawing.Color.Black;
            this.btn_SairProduto.Radius = 15;
            this.btn_SairProduto.Size = new System.Drawing.Size(160, 42);
            this.btn_SairProduto.TabIndex = 11;
            this.btn_SairProduto.Text = "Sair";
            this.btn_SairProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_SairProduto.Click += new System.EventHandler(this.btn_SairProduto_Click);
            // 
            // btn_ConfirmarProduto
            // 
            this.btn_ConfirmarProduto.AnimationHoverSpeed = 0.07F;
            this.btn_ConfirmarProduto.AnimationSpeed = 0.03F;
            this.btn_ConfirmarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarProduto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_ConfirmarProduto.BorderColor = System.Drawing.Color.Black;
            this.btn_ConfirmarProduto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ConfirmarProduto.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ConfirmarProduto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ConfirmarProduto.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmarProduto.Image = null;
            this.btn_ConfirmarProduto.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ConfirmarProduto.Location = new System.Drawing.Point(206, 326);
            this.btn_ConfirmarProduto.Name = "btn_ConfirmarProduto";
            this.btn_ConfirmarProduto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_ConfirmarProduto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ConfirmarProduto.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ConfirmarProduto.OnHoverImage = null;
            this.btn_ConfirmarProduto.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ConfirmarProduto.Radius = 15;
            this.btn_ConfirmarProduto.Size = new System.Drawing.Size(160, 42);
            this.btn_ConfirmarProduto.TabIndex = 10;
            this.btn_ConfirmarProduto.Text = "Confirmar";
            this.btn_ConfirmarProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ConfirmarProduto.Click += new System.EventHandler(this.btn_ConfirmarProduto_Click);
            // 
            // numeroQuantidadeProduto
            // 
            this.numeroQuantidadeProduto.Location = new System.Drawing.Point(87, 255);
            this.numeroQuantidadeProduto.Name = "numeroQuantidadeProduto";
            this.numeroQuantidadeProduto.Size = new System.Drawing.Size(61, 20);
            this.numeroQuantidadeProduto.TabIndex = 8;
            this.numeroQuantidadeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Preço";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Qtd:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // box_NomeProduto
            // 
            this.box_NomeProduto.Location = new System.Drawing.Point(87, 214);
            this.box_NomeProduto.Name = "box_NomeProduto";
            this.box_NomeProduto.Size = new System.Drawing.Size(216, 20);
            this.box_NomeProduto.TabIndex = 2;
            // 
            // imagem_Produto
            // 
            this.imagem_Produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagem_Produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagem_Produto.Image = ((System.Drawing.Image)(resources.GetObject("imagem_Produto.Image")));
            this.imagem_Produto.Location = new System.Drawing.Point(124, 33);
            this.imagem_Produto.Name = "imagem_Produto";
            this.imagem_Produto.Size = new System.Drawing.Size(130, 119);
            this.imagem_Produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagem_Produto.TabIndex = 0;
            this.imagem_Produto.TabStop = false;
            this.imagem_Produto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Cadastro_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 380);
            this.Controls.Add(this.cadastropanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro_Produto";
            this.Load += new System.EventHandler(this.Cadastro_Produto_Load);
            this.cadastropanel.ResumeLayout(false);
            this.cadastropanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroQuantidadeProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem_Produto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cadastropanel;
        private System.Windows.Forms.Label lbl_NomeFoto;
        private System.Windows.Forms.PictureBox imagem_Produto;
        private System.Windows.Forms.TextBox box_NomeProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeroQuantidadeProduto;
        private Guna.UI.WinForms.GunaButton btn_SairProduto;
        private Guna.UI.WinForms.GunaButton btn_ConfirmarProduto;
        private System.Windows.Forms.TextBox box_PrecoProduto;
    }
}