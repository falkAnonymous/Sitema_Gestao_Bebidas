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
            this.controleProduto = new System.Windows.Forms.Panel();
            this.listaProdutosVisual = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // subMenuProduto
            // 
            this.subMenuProduto.Dock = System.Windows.Forms.DockStyle.Left;
            this.subMenuProduto.Location = new System.Drawing.Point(0, 0);
            this.subMenuProduto.Name = "subMenuProduto";
            this.subMenuProduto.Size = new System.Drawing.Size(151, 572);
            this.subMenuProduto.TabIndex = 0;
            // 
            // controleProduto
            // 
            this.controleProduto.Dock = System.Windows.Forms.DockStyle.Right;
            this.controleProduto.Location = new System.Drawing.Point(564, 0);
            this.controleProduto.Name = "controleProduto";
            this.controleProduto.Size = new System.Drawing.Size(108, 572);
            this.controleProduto.TabIndex = 1;
            // 
            // listaProdutosVisual
            // 
            this.listaProdutosVisual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaProdutosVisual.Location = new System.Drawing.Point(151, 0);
            this.listaProdutosVisual.Name = "listaProdutosVisual";
            this.listaProdutosVisual.Size = new System.Drawing.Size(413, 572);
            this.listaProdutosVisual.TabIndex = 2;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel subMenuProduto;
        private System.Windows.Forms.Panel controleProduto;
        private System.Windows.Forms.FlowLayoutPanel listaProdutosVisual;
    }
}