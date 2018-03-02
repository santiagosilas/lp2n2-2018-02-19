using System;
using Microsoft.Extensions.InjecaoDependencia;

namespace InjecaoDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var pedido = serviceProvider.GetService<Pedido>();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IProduct, Product>();
            services.AddTransient<Pedido>();
        }
    }
}
