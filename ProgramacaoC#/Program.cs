using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ProgramacaoC_.Delegate;

namespace ProgramacaoC_
{

    delegate double CalcBinario_double(double x, double y);
    delegate void CalcBinario_void(double x, double y);

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Calculo
            //double n1 = 10;
            //double n2 = 15;

            //CalcBinario_double Cb = CalculoServico.Max;

            //Console.WriteLine(Cb(n1, n2));

            //Console.WriteLine();

            //CalcBinario_void Cbv = CalculoServico.ShowSum;
            //Cbv += CalculoServico.ShowMax;
            //Cbv(n1, n2);
            #endregion

            //Apenas boleano
            #region Predicato

            //List<Produtoss> ProdList = new List<Produtos>();
            //ProdList.Add(new Produtos { Nome = "Tv Lg", Preco = 900.00M });
            //ProdList.Add(new Produtos { Nome = "Picanha", Preco = 50.00M });
            //ProdList.Add(new Produtos { Nome = "Pacote de Chiclete", Preco = 10.00M });
            //ProdList.Add(new Produtos { Nome = "Lavadora", Preco = 3150.00M });

            //ProdList.RemoveAll(preco => preco.Preco <= 100.0M); Retorna um boleano

            //Console.WriteLine("Produtos Na Lista De Compra \n");
            //foreach (Produtos obj in ProdList)
            //{
            //    Console.WriteLine(obj);
            //}

            #endregion

            //Apenas void
            #region Action

            //List<Produtos> ListaProdutos = new List<Produtos>();
            //ListaProdutos.Add(new Produtos("Tv", 900.00M));
            //ListaProdutos.Add(new Produtos("Mouse", 50.00M));
            //ListaProdutos.Add(new Produtos("Tablet", 375.00M));
            //ListaProdutos.Add(new Produtos("Hd Case", 90.0M));

            //Sem o o uso do Action

            //ListaProdutos.ForEach(AtualizandoPreco);

            //foreach (Produtos obj in ListaProdutos)
            //{
            //    Console.WriteLine(obj);
            //}

            // Action sem uso do lambida

            //Action<Produtos> actionProdutos = AtualizandoPreco;       

            //ListaProdutos.ForEach(actionProdutos);

            //foreach (Produtos obj in ListaProdutos)
            //{
            //    Console.WriteLine(obj);
            //}

            // Action com uso do Lambida

            //Action<Produtos> actionProdutos = x =>
            //{
            //    x.Preco += x.Preco * 10 / 100;
            //};

            //ListaProdutos.ForEach(actionProdutos);
            //foreach (Produtoss obj in ListaProdutos)
            //{
            //    Console.WriteLine(obj);
            //}

            #endregion

            //Retorno
            #region Func

            //List<Produtos> ListaProdutos = new List<Produtos>();
            //ListaProdutos.Add(new Produtos("Tv", 900.00M));
            //ListaProdutos.Add(new Produtos("Mouse", 50.00M));
            //ListaProdutos.Add(new Produtos("Tablet", 375.00M));
            //ListaProdutos.Add(new Produtos("Hd Case", 90.0M));

            // Usando a Expressão Lambda

            //List<string> lista = ListaProdutos.Select(x => x.ToString().ToUpper()).ToList();

            //foreach (string obj in lista)
            //{

            //    Console.WriteLine(obj);

            //}

            // Sem A Expressão Lambda

            //List<string> lista2 = ListaProdutos.Select(Toupper).ToList();

            //foreach (string obj in lista2)
            //{
            //    Console.WriteLine(obj);

            //}

            //Usando com a Func

            //Func<Produtos, string> Fupper = Toupper;

            //List<string> lista2 = ListaProdutos.Select(Fupper).ToList();

            //foreach (string obj in lista2)
            //{
            //    Console.WriteLine(obj);
            //}

            #endregion

            //Exercicio

            /*
             Fazer um programa que, a partir de uma lista de produtos, calcule a
             soma dos preços somente dos produtos cujo nome começa com "T".
             
             */

            //List<Produtos> list = new List<Produtos>();
            //list.Add(new Produtos("Tv", 900.00M));
            //list.Add(new Produtos("Mouse", 50.00M));
            //list.Add(new Produtos("Tablet", 350.50M));
            //list.Add(new Produtos("HD Case", 80.90M));

            //Servico_Produto Sp = new Servico_Produto();


            //decimal soma = Sp.FiltraSoma(list, x => x.Nome[0] == 'T');

            //Console.WriteLine(soma);

            // Metodo de como usar o Tipos
            #region Função tipo T

            //void Print<T>(string Mensagem,IEnumerable<T> Colecao)
            //{
            //    foreach (T t in Colecao)
            //    {
            //        Console.WriteLine(t);
            //    }
            //    Console.WriteLine();
            //}
            //Print("tRALALA", ListaProdutos);

            #endregion

        }

        #region Metodo utilizado no ACTION

        //static void AtualizandoPreco(Produtos p1)
        //{
        //    p1.Preco += p1.Preco * 10 / 100;
        //}
        #endregion

        #region Metodo Func

        //static string Toupper(Produtos p)
        //{
        //    return p.Nome.ToUpper();
        //}

        #endregion




    }
}
