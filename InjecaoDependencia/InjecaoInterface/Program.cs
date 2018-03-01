using System;
using InjecaoInterface.Exemplo;
using InjecaoInterface.MeuExemplo;

namespace InjecaoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();
            Disciplina disc = new Disciplina();
            Compra cli = new Compra(pedido);
            Console.WriteLine("Pedido");
            Console.ReadKey();
        }
    }
}