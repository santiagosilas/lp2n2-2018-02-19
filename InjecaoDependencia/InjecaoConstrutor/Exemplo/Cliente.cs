
using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoConstrutor.Exemplo
{
    public class Cliente
    {
        private Pedido pedido;

        public Cliente(Pedido meuPedido)
        {
            pedido = meuPedido;
        }

        public void ObeterPedidos(Pedido pedido)
        {
            pedido.GetPedido(pedido);
        }
    }
}
