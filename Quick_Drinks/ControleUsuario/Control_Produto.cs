using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Drinks.ControleUsuario
{
    public partial class Control_Produto : UserControl
    {

        public Control_Produto()
        {
            InitializeComponent();
        }

        #region Lista de Produtos

        private Image _Iprodutos;
        private string _Nome;
        private string _Quantidade;
        private double _Valor;

        [Category("Propriedade")]
        public Image Imagem
        {
            get { return _Iprodutos; }
            set
            {
                _Iprodutos = value;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = _Iprodutos;
            }
        }

        [Category("Propriedade")]
        public string Nome
        {
            get { return _Nome; }
            set
            {
                _Nome = value;
                lbl_Nome.Text = _Nome;
            }
        }

        [Category("Propriedade")]
        public string Quantidade
        {
            get { return _Quantidade; }
            set
            {
                _Quantidade = value;
                lbl_Quantidade.Text = _Quantidade;
            }

        }

        [Category("Propriedade")]
        public double valor
        {
            get { return _Valor; }
            set
            {
                _Valor = value;
                lbl_Preco.Text = _Valor.ToString("C", new CultureInfo("pt-BR"));
            }


        }


        #endregion
    }
}
