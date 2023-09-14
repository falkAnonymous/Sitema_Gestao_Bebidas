using Quick_Drinks.ControleUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quick_Drinks.Janelas.PastProduto;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Quick_Drinks.Janelas.PastProduto.CadastroProduto
{
    public partial class Cadastro_Produto : Form
    {
        private Produtos _produtosForm;

        //public cadastro_produto(produtos produtosform)
        //{
        //    initializecomponent();
        //    _produtosform = produtosform;
        //}


        public Cadastro_Produto()
        {
            InitializeComponent();
        }

        // Serve para cpturar as teclas numericas e simbolos como ponto e virgula

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagens|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagem_Produto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btn_SairProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cadastro_Produto_Load(object sender, EventArgs e)
        {

        }


        #region Funcão off

        //private void btn_ConfirmarProduto_Click(object sender, EventArgs e)
        //{



        //double valorDouble;
        //string valorProduto = this.box_PrecoProduto.Text;

        //// Verificando se o valor que foi colocado é um numero
        //bool sucesso = double.TryParse(valorProduto, out valorDouble);

        //    if (sucesso)
        //    {
        //        // A conversão foi bem sucedida, agora você pode usar valorDouble





        //    }
        //    else
        //    {
        //        // A conversão falhou. Você pode tratar esse caso como achar melhor.
        //        MessageBox.Show("Por favor, insira um número válido.");
        //    }




        //}
        #endregion


        private void btn_ConfirmarProduto_Click(object sender, EventArgs e)
        {
            Control_Produto CtrlProd = new Control_Produto();

            double valorDouble;
            string valorProduto = this.box_PrecoProduto.Text;

            // Verificando se o valor que foi colocado é um numero
            bool sucesso = double.TryParse(valorProduto, out valorDouble);

            if (sucesso)
            {
                // A conversão foi bem sucedida, agora você pode usar valorDouble


                this.Close();


            }
            else
            {
                // A conversão falhou. Você pode tratar esse caso como achar melhor.
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }
    }
}
