using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoConstrutor.Exemplo
{
    public class Pedido : IPedido
    {
        public double CalcularTotal() => 0;

        internal void GetPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }

    public interface IPedido
    {
        double CalcularTotal();
    }
}
