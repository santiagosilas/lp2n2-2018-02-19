using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class Pedido
    {
        private readonly IProduto _produto;

        public Compra(IProduto produto)
        {
            this._produto = produto;
        }
    }
}
