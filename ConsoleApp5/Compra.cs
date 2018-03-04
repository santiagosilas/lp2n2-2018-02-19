using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Compra
    {
        private readonly IPedido _pedido;

        public Compra(IPedido pedido)
        {
            _pedido = pedido;
        }

        public void ConsultarStatus()
        {
            _pedido.ConsultarStatus();
            System.Console.ReadKey();
        }
    }
}
