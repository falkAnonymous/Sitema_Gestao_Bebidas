using System;
using System.Drawing;
using System.Windows.Forms;
using Quick_Drinks.Janelas;
using Quick_Drinks.Janelas.PastProduto.CadastroProduto.Pedido_Client;
using Quick_Drinks.Entidades;


namespace Quick_Drinks
{
    public partial class Form1 : Form
    {
        private Point PosicaoAtual;
        private bool Liberar = false;

        Produtos produtos = new Produtos();

        public Form1()
        {
            InitializeComponent();

        }

        private void siticonePanel1_MouseDown(object sender, MouseEventArgs e)
        {
            PosicaoAtual = new Point(e.X, e.Y);
            Liberar = true;


        }

        private void siticonePanel1_MouseUp(object sender, MouseEventArgs e)
        {
            Liberar = false;

        }

        private void siticonePanel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (Liberar)
            {
                Point PrePos = PointToScreen(e.Location);
                Location = new Point(PrePos.X - this.PosicaoAtual.X, PrePos.Y - this.PosicaoAtual.Y);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                this.WindowState = FormWindowState.Maximized;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var foto = Image.FromFile(@"D:\Atalhos Area de trabalho\scripts\Csharp Linguagem\ConsoleC#\POO\Quick_Drinks\Icones\Logo\Quick Drinks.png");
            siticoneCirclePictureBox1.Image = foto;
        }

        bool TempMenu;

        private void tempoMenu_Tick(object sender, EventArgs e)
        {
            if (TempMenu)
            {
                panelMenuLateral.Width -= 10;
                if (panelMenuLateral.Width == panelMenuLateral.MinimumSize.Width)
                {
                    TempMenu = false;
                    tempoMenu.Stop();
                }
            }
            else
            {
                panelMenuLateral.Width += 10;
                if (panelMenuLateral.Width == panelMenuLateral.MaximumSize.Width)
                {
                    TempMenu = true;
                    tempoMenu.Stop();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tempoMenu.Start();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            ShowFormsWindows showForms = new ShowFormsWindows(produtos, panelConteudos);
        }


        private void btn_Configuracao_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            ShowFormsWindows showForms = new ShowFormsWindows(pedido, panelConteudos);


        }
    }
}
