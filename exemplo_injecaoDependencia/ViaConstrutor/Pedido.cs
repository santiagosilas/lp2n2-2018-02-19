using System;
using System.Collections.Generic;
using exemplo_injecaoDependencia.Interface;

namespace exemplo_injecaoDependencia{
    public class Pedido : IPedido{

        private double total;
        private List<Produto> Pr;
        public Pedido(List<Produto> pr){
            Pr = pr;
        }
        public void mostrarProdutos(){
            foreach(var produtos in Pr)
            {
                Console.WriteLine(produtos.Id+" "+produtos.Nome+" "+produtos.Preco);
            }
        }

        public double CalculaTotal()
        {
            foreach(var produtos in Pr)
            {
                total += produtos.Preco;
            }
            return total;
        }
    }
}