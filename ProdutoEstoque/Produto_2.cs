using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProdutoEstoque
{
    public class Produto
    {
        public string prodname;
        public double prodprice;
        public int prodstock;
        public double fullprice()
        {
            double full = prodprice * prodstock;
            return full;
        }
        public void adicionar(int quantidade){
            prodstock += quantidade;
        }

        public void remover(int quantidade)
        {
            prodstock -= quantidade;
        }

    }
}
