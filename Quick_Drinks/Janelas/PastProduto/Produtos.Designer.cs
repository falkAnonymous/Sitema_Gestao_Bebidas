namespace Quick_Drinks.Janelas
{
    partial class Produtos
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
            this.subMenuProduto = new System.Windows.Forms.Panel();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.controleProduto = new System.Windows.Forms.Panel();
            this.listaProdutosVisual = new System.Windows.Forms.FlowLayoutPanel();
            this.subMenuProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // subMenuProduto
            // 
            this.subMenuProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subMenuProduto.Controls.Add(this.btn_Editar);
            this.subMenuProduto.Controls.Add(this.btn_Adicionar);
            this.subMenuProduto.Controls.Add(this.btn_Excluir);
            this.subMenuProduto.Dock = System.Windows.Forms.DockStyle.Left;
            this.subMenuProduto.Location = new System.Drawing.Point(0, 0);
            this.subMenuProduto.Name = "subMenuProduto";
            this.subMenuProduto.Size = new System.Drawing.Size(151, 572);
            this.subMenuProduto.TabIndex = 0;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Editar.Location = new System.Drawing.Point(7, 483);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(133, 33);
            this.btn_Editar.TabIndex = 2;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Adicionar.Location = new System.Drawing.Point(7, 444);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(133, 33);
            this.btn_Adicionar.TabIndex = 1;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Excluir.Location = new System.Drawing.Point(7, 524);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(133, 33);
            this.btn_Excluir.TabIndex = 0;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // controleProduto
            // 
            this.controleProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.controleProduto.Dock = System.Windows.Forms.DockStyle.Right;
            this.controleProduto.Location = new System.Drawing.Point(598, 0);
            this.controleProduto.Name = "controleProduto";
            this.controleProduto.Size = new System.Drawing.Size(74, 572);
            this.controleProduto.TabIndex = 1;
            // 
            // listaProdutosVisual
            // 
            this.listaProdutosVisual.AutoScroll = true;
            this.listaProdutosVisual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaProdutosVisual.Location = new System.Drawing.Point(151, 0);
            this.listaProdutosVisual.Name = "listaProdutosVisual";
            this.listaProdutosVisual.Size = new System.Drawing.Size(447, 572);
            this.listaProdutosVisual.TabIndex = 2;
            this.listaProdutosVisual.Paint += new System.Windows.Forms.PaintEventHandler(this.listaProdutosVisual_Paint);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(672, 572);
            this.Controls.Add(this.listaProdutosVisual);
            this.Controls.Add(this.controleProduto);
            this.Controls.Add(this.subMenuProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.subMenuProduto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel subMenuProduto;
        private System.Windows.Forms.Panel controleProduto;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Excluir;
        public System.Windows.Forms.FlowLayoutPanel listaProdutosVisual;
    }
}