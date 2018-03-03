using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftExtension.Exemplo
{
    class Compra
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

    public interface IPedido
    {
        void ConsultarStatus();
    }
    
}
