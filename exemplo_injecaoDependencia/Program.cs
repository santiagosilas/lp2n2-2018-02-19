using exemplo_injecaoDependencia.ViaConstrutor;
using System;
using System.Collections.Generic;

namespace exemplo_injecaoDependencia.ViaConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            //controle de inversão por meio do construtor e interface
            //desvantagens: a depedência do objeto não pode ser alterada
            Produto p = new Produto();
            Console.WriteLine("Bem vindo!");

            Console.WriteLine("Digite a quantidade de produtos: ");
            int num = Convert.ToInt32(Console.ReadLine());
            List<Produto> produtos = new List<Produto>();

            Console.WriteLine("Nome e preço do pedido nessa ordem.");
            for(int i = 1; i <= num; i++)
                produtos.Add(new Produto(){Id = i, Nome = Console.ReadLine(), Preco = Convert.ToDouble(Console.ReadLine())});
            Cliente c = new Cliente(new Pedido(produtos));
            Pedido pe = new Pedido(produtos);
            Console.WriteLine("\n"+pe.CalculaTotal());
        }
    }
}
