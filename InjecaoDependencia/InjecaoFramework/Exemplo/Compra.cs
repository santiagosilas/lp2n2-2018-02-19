using System;
using System.Collections.Generic;
using System.Text;


namespace InjecaoFramework.Exemplo
{
    class Compra
    {
        private readonly IPedido _pedido;
        public Compra(IPedido pedido)
        {
            this._pedido = pedido;
        }
        public double CalcularTotal()
        {
            return this._pedido.CalcularTotal();
        }
    }
}
