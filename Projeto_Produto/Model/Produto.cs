using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Produto.Model
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public Categoria Categorias { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Produto:\n");
            sb.Append($"Id :{Id}");
            sb.Append($"\nNome : {Nome} ");
            sb.Append($"\nPreço :{Preco.ToString("F2", CultureInfo.InvariantCulture)} ");
            sb.AppendLine($"\nQuantidade :{Quantidade}");
            sb.AppendLine("\n*Categoria*\n");
            sb.Append($"Id : {Categorias.Id} ");
            sb.Append($"\nNome : {Categorias.Nome} ");
            sb.Append($"\nNivel : {Categorias.Nivel}\n");
            sb.AppendLine("*---------------------*");
            return sb.ToString();

        }

    }
}
