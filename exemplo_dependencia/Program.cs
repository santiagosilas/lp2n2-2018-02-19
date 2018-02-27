using System;
using System.Collections.Generic;

namespace exemplo_dependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("Informe o nome do seu pedido");
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto(){Nome = Console.ReadLine()});
        }
    }
}
