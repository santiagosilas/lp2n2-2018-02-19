using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    public class ContaCorrente : IConta
    {
        public Double Saldo { get; set; }
        public int Numero { get; set; }
        public double Juros { get; set; }

    }
}
