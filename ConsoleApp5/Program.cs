using System;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceColection = new ServiceCollection();

            ConfigureService(serviceColection);

            var serviceProvider = serviceColection.BuildServiceProvider();
            var compra = serviceProvider.GetService<Compra>();

            compra.ConsultarStatus();
        }

        private static void ConfigureService(IServiceCollection services)
        {
            services.AddTransient<IPedido, Pedido>();
            services.AddTransient<Compra>();
        }
    }
}
