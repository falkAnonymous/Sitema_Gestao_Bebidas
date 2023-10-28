using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Drinks.Janelas.PastProduto.CadastroProduto.Pedido_Client
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
            painel_PedidoFormulario.Visible = false;
            listadePedido.Visible = false;
        }

        private void solicitar_Click(object sender, EventArgs e)
        {
            painel_PedidoFormulario.Visible = true;
            listadePedido.Visible = true;
        }
    }
}
