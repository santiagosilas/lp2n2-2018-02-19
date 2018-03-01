using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoFramework.Exemplo
{
    class Pedido : IPedido
    {
        public double CalcularTotal() => 0;
    }

    public interface IPedido
    {
        double CalcularTotal();
    }
}
