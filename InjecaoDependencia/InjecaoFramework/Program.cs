using System;
using InjecaoFramework.Exemplo;
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
            Console.WriteLine("Total = "+ compra.CalcularTotal());
            Console.ReadKey();
        }
    }
}