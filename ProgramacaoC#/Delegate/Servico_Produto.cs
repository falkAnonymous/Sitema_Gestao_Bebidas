using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoC_.Delegate
{
    internal class Servico_Produto
    {
        public decimal FiltraSoma(List<Produtos> list,Func<Produtos,bool> lambda)
        {
            decimal soma = 0.0m;
            foreach(Produtos x in list)
            {
                if (lambda.Invoke(x))
                {
                    soma += x.Preco;
                }
            }
            return soma;
        }

        

    }
}
