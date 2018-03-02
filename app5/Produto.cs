using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class Produto : IProduto
    {
        public string ConsutarStatus()
        {
            return "OK";
        }
    }
}
