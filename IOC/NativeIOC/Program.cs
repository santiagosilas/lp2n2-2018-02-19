using Microsoft.Extensions.DependencyInjection;
using System;

namespace NativeIOC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            

        }
        public static void ConfigureServices(IServiceCollection service)
        {
            service.AddTransient<IPedido, Pedido>();
        }
    }
}
