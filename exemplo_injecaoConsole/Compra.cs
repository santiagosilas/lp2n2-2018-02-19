using System;

namespace exemplo_injecaoConsole
{
    public class Compra{

        private readonly IPedido _pedido;

        public Compra(IPedido pedido){

            _pedido = pedido;
        }

        public void ConsultarStatus(){

            _pedido.ConsultarStatus();
        }

    }
}