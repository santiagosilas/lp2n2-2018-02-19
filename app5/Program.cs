using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
        }
        public static void ConfigureServices(IServiceCollection service)
        {
            service.AddTransient<IProduto, Produto>();
        }
    }
}
