using System;
using System.Collections.Generic;
using System.Text;

namespace ViaPropriedades
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
