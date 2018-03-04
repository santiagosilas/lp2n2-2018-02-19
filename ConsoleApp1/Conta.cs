using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject
{
    public class Conta : IConta
    {
        public Double Saldo { get; set; }
        public int Numero { get; set; }
    }
}
