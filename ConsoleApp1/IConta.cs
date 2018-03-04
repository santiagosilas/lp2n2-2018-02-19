using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject
{
    public interface IConta
    {
        Double Saldo { get; set; }
        int Numero { get; set; }
    }
}
