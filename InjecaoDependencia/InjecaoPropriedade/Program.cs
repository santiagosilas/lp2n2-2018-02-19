using System;
using InjecaoPropriedade.Exemplo;
using InjecaoPropriedade.MeuExemplo;

namespace InjecaoPropriedade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido p = new Pedido();
            Cliente cli = new Cliente();

            Disciplina d = new Disciplina();
            Curso c = new Curso();

            Console.WriteLine("Total de Pedidos =  " + p.CalcularTotal());
            Console.WriteLine("\nListar disciplinas:  " + d.Listar());

            Console.ReadKey();
        }
    }
}