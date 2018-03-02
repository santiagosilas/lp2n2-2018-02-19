using System;
using System.Collections.Generic;
using System.Text;

namespace Propriedades
{
    class Pedido
    {
        public Pedido()
        {

        }

        private IProduct myProduct;

        public IProduct product { get; set; }
    }
}
