using Ninject;
using System;

namespace Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            var ninjectKernel = new StandardKernel();

            ninjectKernel.Bind<IProduct>().To<Product>();

            var product = ninjectKernel.Get<IProduct>();
            var pedido = new Pedido(product);
        }
    }
}
