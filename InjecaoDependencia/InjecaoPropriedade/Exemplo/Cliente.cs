using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoPropriedade.Exemplo
{
    public class Cliente
    {
        public Cliente()
        {
        }
        private IPedido meuPedido;
        public IPedido Pedido{get; set;}
         
    }     
}
