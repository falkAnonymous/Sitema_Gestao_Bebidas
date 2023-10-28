namespace Quick_Drinks.Janelas.PastProduto.CadastroProduto.Pedido_Client
{
    partial class Pedido
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
            this.painel_Pedido01 = new System.Windows.Forms.Panel();
            this.solicitar = new System.Windows.Forms.Button();
            this.painel_Pedido_ShowForm01 = new System.Windows.Forms.Panel();
            this.listadePedido = new System.Windows.Forms.ListView();
            this.painel_PedidoFormulario = new System.Windows.Forms.Panel();
            this.grid_MenuPedidoForm = new System.Windows.Forms.FlowLayoutPanel();
            this.painel_Pedido01.SuspendLayout();
            this.painel_Pedido_ShowForm01.SuspendLayout();
            this.painel_PedidoFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_Pedido01
            // 
            this.painel_Pedido01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painel_Pedido01.Controls.Add(this.solicitar);
            this.painel_Pedido01.Dock = System.Windows.Forms.DockStyle.Left;
            this.painel_Pedido01.Location = new System.Drawing.Point(0, 0);
            this.painel_Pedido01.Name = "painel_Pedido01";
            this.painel_Pedido01.Size = new System.Drawing.Size(192, 572);
            this.painel_Pedido01.TabIndex = 0;
            // 
            // solicitar
            // 
            this.solicitar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solicitar.Location = new System.Drawing.Point(0, 0);
            this.solicitar.Name = "solicitar";
            this.solicitar.Size = new System.Drawing.Size(188, 568);
            this.solicitar.TabIndex = 0;
            this.solicitar.Text = "Fazer Pedido";
            this.solicitar.UseVisualStyleBackColor = true;
            this.solicitar.Click += new System.EventHandler(this.solicitar_Click);
            // 
            // painel_Pedido_ShowForm01
            // 
            this.painel_Pedido_ShowForm01.Controls.Add(this.listadePedido);
            this.painel_Pedido_ShowForm01.Controls.Add(this.painel_PedidoFormulario);
            this.painel_Pedido_ShowForm01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_Pedido_ShowForm01.Location = new System.Drawing.Point(192, 0);
            this.painel_Pedido_ShowForm01.Name = "painel_Pedido_ShowForm01";
            this.painel_Pedido_ShowForm01.Size = new System.Drawing.Size(658, 572);
            this.painel_Pedido_ShowForm01.TabIndex = 1;
            // 
            // listadePedido
            // 
            this.listadePedido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadePedido.HideSelection = false;
            this.listadePedido.Location = new System.Drawing.Point(0, 455);
            this.listadePedido.Name = "listadePedido";
            this.listadePedido.Size = new System.Drawing.Size(658, 117);
            this.listadePedido.TabIndex = 1;
            this.listadePedido.UseCompatibleStateImageBehavior = false;
            // 
            // painel_PedidoFormulario
            // 
            this.painel_PedidoFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painel_PedidoFormulario.AutoSize = true;
            this.painel_PedidoFormulario.BackColor = System.Drawing.Color.Gainsboro;
            this.painel_PedidoFormulario.Controls.Add(this.grid_MenuPedidoForm);
            this.painel_PedidoFormulario.Location = new System.Drawing.Point(17, 12);
            this.painel_PedidoFormulario.Name = "painel_PedidoFormulario";
            this.painel_PedidoFormulario.Size = new System.Drawing.Size(619, 423);
            this.painel_PedidoFormulario.TabIndex = 0;
            // 
            // grid_MenuPedidoForm
            // 
            this.grid_MenuPedidoForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_MenuPedidoForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.grid_MenuPedidoForm.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.grid_MenuPedidoForm.Location = new System.Drawing.Point(0, 0);
            this.grid_MenuPedidoForm.Name = "grid_MenuPedidoForm";
            this.grid_MenuPedidoForm.Size = new System.Drawing.Size(166, 423);
            this.grid_MenuPedidoForm.TabIndex = 0;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(850, 572);
            this.Controls.Add(this.painel_Pedido_ShowForm01);
            this.Controls.Add(this.painel_Pedido01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.painel_Pedido01.ResumeLayout(false);
            this.painel_Pedido_ShowForm01.ResumeLayout(false);
            this.painel_Pedido_ShowForm01.PerformLayout();
            this.painel_PedidoFormulario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel_Pedido01;
        private System.Windows.Forms.Button solicitar;
        private System.Windows.Forms.Panel painel_Pedido_ShowForm01;
        private System.Windows.Forms.Panel painel_PedidoFormulario;
        private System.Windows.Forms.ListView listadePedido;
        private System.Windows.Forms.FlowLayoutPanel grid_MenuPedidoForm;
    }
}