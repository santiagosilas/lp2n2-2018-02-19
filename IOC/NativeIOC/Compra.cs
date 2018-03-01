using System;
using System.Collections.Generic;
using System.Text;

namespace NativeIOC
{
    public class Compra
    {
        private readonly IPedido _pedido;

        public Compra(IPedido pedido)
        {
            this._pedido = pedido;
        }
    }
}
