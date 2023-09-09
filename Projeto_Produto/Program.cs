using System;
using System.Collections.Generic;
using System.Linq;
using Projeto_Produto.Model;

namespace Projeto_Produto
{
    internal class Program
    {

        static void MensagemAviso<T>(string mensagem, IEnumerable<T> Colecao)
        {
            foreach (var t in Colecao)
            {
                Console.WriteLine(t);
            }
        }

        static void Main(string[] args)
        {
            Categoria c1 = new Categoria() { Id = 1, Nivel = 3, Nome = "Video Games" };
            Categoria c2 = new Categoria() { Id = 2, Nivel = 1, Nome = "Computadores" };
            Categoria c3 = new Categoria() { Id = 3, Nivel = 2, Nome = "Ferramentas" };

            List<Produto> lista = new List<Produto>();
            lista.Add(new Produto() { Nome = "Xbox Series X", Id = 1, Preco = 499.99, Quantidade = 10, Categorias = c1 });
            lista.Add(new Produto() { Nome = "PlayStation 5", Id = 2, Preco = 499.99, Quantidade = 10, Categorias = c1 });
            lista.Add(new Produto() { Nome = "Nintendo Switch", Id = 3, Preco = 299.99, Quantidade = 10, Categorias = c1 });
            lista.Add(new Produto() { Nome = "Dell XPS 13", Id = 4, Preco = 999.99, Quantidade = 5, Categorias = c2 });
            lista.Add(new Produto() { Nome = "MacBook Pro", Id = 5, Preco = 1299.99, Quantidade = 5, Categorias = c2 });
            lista.Add(new Produto() { Nome = "HP Spectre x360", Id = 6, Preco = 1199.99, Quantidade = 5, Categorias = c2 });
            lista.Add(new Produto() { Nome = "Chave de Fenda", Id = 7, Preco = 9.99, Quantidade = 50, Categorias = c3 });
            lista.Add(new Produto() { Nome = "Martelo", Id = 8, Preco = 14.99, Quantidade = 50, Categorias = c3 });
            lista.Add(new Produto() { Nome = "Alicate", Id = 9, Preco = 12.99, Quantidade = 50, Categorias = c3 });
            lista.Add(new Produto() { Nome = "Furadeira", Id = 10, Preco = 49.99, Quantidade = 20, Categorias = c3 });


            var R1 = lista.Where(x => x.Categorias.Id == 1 && x.Preco < 900.00);
            Console.WriteLine("Nivel 1 , Preços Menores Que 900 Reais");
            Console.WriteLine();

            MensagemAviso("Ta Correto", R1);

            


        }
    }
}
