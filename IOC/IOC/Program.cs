using System;
using Ninject;

namespace IOC
{
    public class Program
    {
        static void Main(string[] args)
        {

            var ninject = new StandardKernel();
            ninject.Bind<IConta>().To<ContaCorrente>();
        }
    }
}
