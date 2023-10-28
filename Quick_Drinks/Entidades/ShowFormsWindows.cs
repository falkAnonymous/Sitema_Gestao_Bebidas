using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Quick_Drinks.Entidades
{
    internal class ShowFormsWindows
    {

        public ShowFormsWindows(Form janela, System.Windows.Forms.Panel panel1)
        {
            
            janela.TopLevel = false;// Não autoriza ele ficar na frente da aplicação principal
            janela.Dock = DockStyle.Fill;// Avisa que ele ira prencheer todo o campo dentro do panel
            panel1.Controls.Clear();// Limpa a ultima janela anterior
            panel1.Controls.Add(janela);// adicionar o janela dentro do panel
            janela.Show();// Chama a visualização da janela  dentro do panel
        }
    }
}
