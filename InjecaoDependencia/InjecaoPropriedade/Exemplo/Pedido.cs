using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoPropriedade.Exemplo
{
   public class Pedido : IPedido 
   {
        public double CalcularTotal() => 0;
   }
    
   public interface IPedido
    {
        double CalcularTotal();
    }
}
