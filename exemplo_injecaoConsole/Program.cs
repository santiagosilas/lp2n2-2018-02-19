using Microsoft.Extensions.DependencyInjection;
using System;

namespace exemplo_injecaoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var compra = serviceProvider.GetService<Compra>();

            compra.ConsultarStatus();

        }

        private static void ConfigureServices(IServiceCollection services){
            services.AddTransient<IPedido, Pedido>();
            services.AddTransient<Compra>();
        }
    }
}
