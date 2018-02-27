using System;
using Implementacao;
using Ninject.Modules;
using Ninject;
using Interface;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ninjectKernel = new StandardKernel();

            ninjectKernel.Bind<IProduto>().To<Produto>();

            var produto = ninjectKernel.Get<IProduto>();
            var compra = new Compra(produto);
            var preco = compra.CalcularPreco();
        }
    }
}
