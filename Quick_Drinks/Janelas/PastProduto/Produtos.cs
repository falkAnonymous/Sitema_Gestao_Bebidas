using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quick_Drinks.Janelas.PastProduto.CadastroProduto;
using System.Windows.Forms;
using Quick_Drinks.ControleUsuario;

namespace Quick_Drinks.Janelas
{
    public partial class Produtos : Form
    {
        Cadastro_Produto cadProd;

        public Produtos()
        {
            InitializeComponent();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen("Cadastro_Produto"))
            {
                cadProd = new Cadastro_Produto(listaProdutosVisual);
                cadProd.TopLevel = true;
                cadProd.ShowDialog();
            }
           


        }

        #region Validador Janelas Abertas

        public bool IsFormOpen(string formName)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formName)
                {
                    return true;
                }
            }
            return false;

            //else
            //{
            //    MessageBox.Show("O formulário Cadastro_Produto já está aberto.");
            //}

        }
        #endregion

        private void listaProdutosVisual_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
