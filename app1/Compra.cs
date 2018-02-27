using Implementacao;
using Interface;

namespace Implementacao
{
    class Compra
    {
        private readonly IProduto _produto;

        public Compra(IProduto produto)
        {
            this._produto = produto;
        }

        public double CalcularPreco() {
            return this._produto.Preco();
        }
    }
}