using System;
using InjecaoFramework.Exemplo;
using InjecaoFramework.MeuExemplo;
using Ninject;

namespace InjecaoFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia o kernel do Ninject
            var ninjecKernel = new StandardKernel();
            //Redireciona a implementação da nterface para a classe  concreta especificada
            ninjecKernel.Bind<IPedido>().To<Pedido>();

            var pedido = ninjecKernel.Get<IPedido>();
            var compra = new Compra(pedido);
            var total = compra.CalcularTotal();

            ninjecKernel.Bind<IDisciplina>().To<Disciplina>();

            var disciplina = ninjecKernel.Get<IDisciplina>();
            var curso = new Curso(disciplina);
            var lista = curso.ListarDisciplina(); 

            Console.WriteLine("Total Pedido =  "+ pedido.CalcularTotal());
            Console.WriteLine("\nListar Disciplina =  " + disciplina.ListarDisciplina());

            Console.ReadKey();

        }
    }
}