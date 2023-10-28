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
using System.Globalization;
using System.Web.UI;
using System.Web.ModelBinding;

namespace Quick_Drinks.Janelas.PastProduto.CadastroProduto
{
    public partial class Cadastro_Produto : Form
    {
        // Guarda a referência do painel onde ficaram os produtos
        private FlowLayoutPanel _flowLayoutPanel;

        // Construtor com parametro para receber a referência do painel onde ficarão listados os propdutos
        public Cadastro_Produto(FlowLayoutPanel produtosFlow)
        {
            InitializeComponent();

            // instância do painel recebida no construtor passada para o campo privado para ficar acessivel na classe 
            _flowLayoutPanel = produtosFlow;
        }




        // Serve para capturar as teclas numericas e simbolos como ponto e virgula

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 44)
            {
                e.Handled = true;
            }
        }
        //Serve para colocar uma imagem no picture box
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
            // Cria a instância do controle de usuario para guardar os dados do produto
            Control_Produto CtrlProd = new Control_Produto();


            string valorProduto = this.box_PrecoProduto.Text; //Preço do produto



            if (valorProduto == String.Empty)
            {

                MessageBox.Show("Por favor, insira um número válido.");
            }
            else
            {
                double _Preco_em_Double = double.Parse(valorProduto);



                // Preenche os dados no controle do produto

                CtrlProd.Visible = true;
                CtrlProd.Imagem = imagem_Produto.Image;
                CtrlProd.Nome = box_NomeProduto.Text;
                CtrlProd.Quantidade = numeroQuantidadeProduto.Text;
                CtrlProd.valor = _Preco_em_Double;

                // Adiciona o controle ao painel pricipal usando a referência do painel obtida anteriormente na contrução do objeto da classe

                _flowLayoutPanel.Controls.Add(CtrlProd);

                // Fecha a janela de preenchimento de dados
                this.Close();
            }






        }
    }
}
