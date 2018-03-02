using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoDependencia
{
    public class Pedido
    {
        private readonly IProduct _product;

        public Pedido(Product product)
        {
            _product = product;
        }
    }
}
