using System;
using InjecaoConstrutor.Exemplo;
using InjecaoConstrutor.MeuExemplo;
namespace InjecaoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido p = new Pedido();
            Cliente cli = new Cliente(p);

            Disciplina d = new Disciplina();
            Curso c = new Curso(d);

            Console.WriteLine("Total Pedidos =  " + p.CalcularTotal());
            Console.WriteLine("\nTotal de Disciplinas =  " + d.TotalDisciplina());
            Console.ReadKey();
        }
        
    }
}
