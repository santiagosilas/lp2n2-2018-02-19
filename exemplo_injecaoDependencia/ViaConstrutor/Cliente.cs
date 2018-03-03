using System;
using System.Collections.Generic;

namespace exemplo_injecaoDependencia{

    public class Cliente{
        private Pedido pedido;

        public Cliente(Pedido p){
            pedido = p;
            pedido.mostrarProdutos();
        }
    }
}