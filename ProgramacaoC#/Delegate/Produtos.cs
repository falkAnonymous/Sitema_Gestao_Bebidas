using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoC_.Delegate
{
    internal class Produtos
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produtos()
        {

        }

        public Produtos(string nome, decimal Produtos)
        {
            this.Nome = nome;
            this.Preco = Produtos;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Produtos: {Nome} \nPreço R${Preco.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
