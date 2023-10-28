namespace Quick_Drinks
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.BordaJanela = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tempoMenu = new System.Windows.Forms.Timer(this.components);
            this.siticonePanel5 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btn_Sobre = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel4 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btn_Ajuda = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btn_Configuracao = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel6 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btn_Inicio = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.siticoneCirclePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.panelMenuLateral = new System.Windows.Forms.FlowLayoutPanel();
            this.panelConteudos = new System.Windows.Forms.Panel();
            this.BordaJanela.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.siticonePanel5.SuspendLayout();
            this.siticonePanel4.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            this.siticonePanel6.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            this.panelMenuLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.BorderRadius = 45;
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.DragForm = false;
            this.siticoneBorderlessForm1.ShadowColor = System.Drawing.Color.Lime;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // BordaJanela
            // 
            this.BordaJanela.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BordaJanela.Controls.Add(this.siticonePanel1);
            this.BordaJanela.Dock = System.Windows.Forms.DockStyle.Top;
            this.BordaJanela.Location = new System.Drawing.Point(0, 0);
            this.BordaJanela.Name = "BordaJanela";
            this.BordaJanela.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.BordaJanela.Size = new System.Drawing.Size(900, 48);
            this.BordaJanela.TabIndex = 0;
            this.BordaJanela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.siticonePanel1_MouseDown);
            this.BordaJanela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.siticonePanel1_MouseMove);
            this.BordaJanela.MouseUp += new System.Windows.Forms.MouseEventHandler(this.siticonePanel1_MouseUp);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.pictureBox1);
            this.siticonePanel1.Controls.Add(this.pictureBox2);
            this.siticonePanel1.Controls.Add(this.pictureBox3);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticonePanel1.Location = new System.Drawing.Point(674, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(226, 48);
            this.siticonePanel1.TabIndex = 0;
            this.siticonePanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.siticonePanel1_MouseDown);
            this.siticonePanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.siticonePanel1_MouseMove);
            this.siticonePanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.siticonePanel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(109, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(41, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseClick);
            // 
            // tempoMenu
            // 
            this.tempoMenu.Interval = 10;
            this.tempoMenu.Tick += new System.EventHandler(this.tempoMenu_Tick);
            // 
            // siticonePanel5
            // 
            this.siticonePanel5.Controls.Add(this.btn_Sobre);
            this.siticonePanel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.siticonePanel5.Location = new System.Drawing.Point(3, 255);
            this.siticonePanel5.Name = "siticonePanel5";
            this.siticonePanel5.Size = new System.Drawing.Size(225, 40);
            this.siticonePanel5.TabIndex = 3;
            // 
            // btn_Sobre
            // 
            this.btn_Sobre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sobre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sobre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Sobre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Sobre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sobre.Font = new System.Drawing.Font("Pacifico", 14.25F);
            this.btn_Sobre.ForeColor = System.Drawing.Color.White;
            this.btn_Sobre.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sobre.Image")));
            this.btn_Sobre.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Sobre.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Sobre.Location = new System.Drawing.Point(0, 0);
            this.btn_Sobre.Name = "btn_Sobre";
            this.btn_Sobre.Size = new System.Drawing.Size(225, 40);
            this.btn_Sobre.TabIndex = 5;
            this.btn_Sobre.Text = "Sobre";
            this.btn_Sobre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // siticonePanel4
            // 
            this.siticonePanel4.Controls.Add(this.btn_Ajuda);
            this.siticonePanel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.siticonePanel4.Location = new System.Drawing.Point(3, 209);
            this.siticonePanel4.Name = "siticonePanel4";
            this.siticonePanel4.Size = new System.Drawing.Size(225, 40);
            this.siticonePanel4.TabIndex = 2;
            // 
            // btn_Ajuda
            // 
            this.btn_Ajuda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ajuda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ajuda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Ajuda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Ajuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Ajuda.Font = new System.Drawing.Font("Pacifico", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajuda.ForeColor = System.Drawing.Color.White;
            this.btn_Ajuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ajuda.Image")));
            this.btn_Ajuda.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Ajuda.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Ajuda.Location = new System.Drawing.Point(0, 0);
            this.btn_Ajuda.Name = "btn_Ajuda";
            this.btn_Ajuda.Size = new System.Drawing.Size(225, 40);
            this.btn_Ajuda.TabIndex = 4;
            this.btn_Ajuda.Text = "Ajuda";
            this.btn_Ajuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.btn_Configuracao);
            this.siticonePanel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.siticonePanel3.Location = new System.Drawing.Point(3, 163);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(225, 40);
            this.siticonePanel3.TabIndex = 1;
            // 
            // btn_Configuracao
            // 
            this.btn_Configuracao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Configuracao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Configuracao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Configuracao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Configuracao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Configuracao.Font = new System.Drawing.Font("Pacifico", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Configuracao.ForeColor = System.Drawing.Color.White;
            this.btn_Configuracao.Image = ((System.Drawing.Image)(resources.GetObject("btn_Configuracao.Image")));
            this.btn_Configuracao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Configuracao.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Configuracao.Location = new System.Drawing.Point(0, 0);
            this.btn_Configuracao.Name = "btn_Configuracao";
            this.btn_Configuracao.Size = new System.Drawing.Size(225, 40);
            this.btn_Configuracao.TabIndex = 3;
            this.btn_Configuracao.Text = "Configuração";
            this.btn_Configuracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Configuracao.Click += new System.EventHandler(this.btn_Configuracao_Click);
            // 
            // siticonePanel6
            // 
            this.siticonePanel6.Controls.Add(this.btn_Inicio);
            this.siticonePanel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.siticonePanel6.Location = new System.Drawing.Point(3, 117);
            this.siticonePanel6.Name = "siticonePanel6";
            this.siticonePanel6.Size = new System.Drawing.Size(225, 40);
            this.siticonePanel6.TabIndex = 4;
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Inicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Inicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Inicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Inicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Inicio.Font = new System.Drawing.Font("Pacifico", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.ForeColor = System.Drawing.Color.White;
            this.btn_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inicio.Image")));
            this.btn_Inicio.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Inicio.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Inicio.Location = new System.Drawing.Point(0, 0);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(225, 40);
            this.btn_Inicio.TabIndex = 2;
            this.btn_Inicio.Text = "Home";
            this.btn_Inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.pictureBox4);
            this.siticonePanel2.Controls.Add(this.siticoneCirclePictureBox1);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.siticonePanel2.Location = new System.Drawing.Point(3, 3);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(225, 108);
            this.siticonePanel2.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(9, 45);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.ImageRotate = 0F;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(111, 5);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(100, 100);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticoneCirclePictureBox1.TabIndex = 0;
            this.siticoneCirclePictureBox1.TabStop = false;
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(11)))), ((int)(((byte)(233)))));
            this.panelMenuLateral.Controls.Add(this.siticonePanel2);
            this.panelMenuLateral.Controls.Add(this.siticonePanel6);
            this.panelMenuLateral.Controls.Add(this.siticonePanel3);
            this.panelMenuLateral.Controls.Add(this.siticonePanel4);
            this.panelMenuLateral.Controls.Add(this.siticonePanel5);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 48);
            this.panelMenuLateral.MaximumSize = new System.Drawing.Size(228, 820);
            this.panelMenuLateral.MinimumSize = new System.Drawing.Size(50, 820);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(50, 820);
            this.panelMenuLateral.TabIndex = 1;
            // 
            // panelConteudos
            // 
            this.panelConteudos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudos.Location = new System.Drawing.Point(50, 48);
            this.panelConteudos.Name = "panelConteudos";
            this.panelConteudos.Size = new System.Drawing.Size(850, 572);
            this.panelConteudos.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.panelConteudos);
            this.Controls.Add(this.panelMenuLateral);
            this.Controls.Add(this.BordaJanela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BordaJanela.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.siticonePanel5.ResumeLayout(false);
            this.siticonePanel4.ResumeLayout(false);
            this.siticonePanel3.ResumeLayout(false);
            this.siticonePanel6.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            this.panelMenuLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel BordaJanela;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Timer tempoMenu;
        private System.Windows.Forms.FlowLayoutPanel panelMenuLateral;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel6;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_Inicio;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_Configuracao;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_Ajuda;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_Sobre;
        private System.Windows.Forms.Panel panelConteudos;
    }
}

