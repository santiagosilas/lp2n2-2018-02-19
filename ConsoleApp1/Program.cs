using Ninject;
using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IConta>().To<Conta>();
        }
    }
}
