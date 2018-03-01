using System;

namespace IOC
{
    public class ContaPoupanca : IConta
    {
        public Double Saldo { get; set; }
        public int Numero { get; set; }
        public Double Rendimentos { get; set; }
    }
}