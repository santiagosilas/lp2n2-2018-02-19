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
           Compra cli = new Compra(pedido);

            Disciplina d = new Disciplina();
            Curso c = new Curso(d);

            Console.WriteLine("Total de Pedido =  " + pedido.CalcularTotal());
            Console.WriteLine("\nDisciplina:  " + d.Listar());
            Console.ReadKey();
        }
    }
}