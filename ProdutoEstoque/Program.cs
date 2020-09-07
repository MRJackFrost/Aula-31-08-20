using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using ProdutoEstoque;

namespace ProdutoEstoque
{
    
    }
    class Program 
    {
        static void Main(string[] args)
        {

            Produto novo;
            novo = new Produto();
            Console.WriteLine("Qual o nome do produto?");
            novo.prodname = Console.ReadLine();
            Console.WriteLine("Qual o preço do produto "+novo.prodname);
            novo.prodprice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos " + novo.prodname + " tem em estoque?");
            novo.prodstock = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double stock = novo.fullprice();

            Console.WriteLine("Dados do produto: " + novo.prodname + ", preço: R$" + novo.prodprice + ", estoque: " + novo.prodstock + " preço total: R$" + stock);
            Console.Write("Digite um numero a ser adicionado ao estoque: ");
            novo.adicionar(int.Parse(Console.ReadLine()));
            stock = novo.fullprice();

            Console.WriteLine("Dados do produto: " + novo.prodname + ", preço: R$" + novo.prodprice + ", estoque: " + novo.prodstock + " preço total: R$" + stock);
            Console.Write("Digite um numero a ser removido do estoque ao estoque: ");
            novo.remover(int.Parse(Console.ReadLine()));
            stock = novo.fullprice();
         
            Console.WriteLine("Dados do produto: " + novo.prodname + ", preço: R$" + novo.prodprice + ", estoque: " + novo.prodstock + " preço total: R$" + stock);
            Console.ReadKey();
        }
    }


