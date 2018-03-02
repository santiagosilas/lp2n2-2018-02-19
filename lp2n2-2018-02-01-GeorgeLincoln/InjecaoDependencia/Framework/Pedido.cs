using System;
using System.Collections.Generic;
using System.Text;

namespace Framework
{
    public class Pedido
    {
        private readonly IProduct _product;
        public Pedido(IProduct product)
        {
            this._product = product;
        }
    }
}
