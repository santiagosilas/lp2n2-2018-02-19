﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject
{
    public class Pessoa
    {
        private readonly IConta _conta;
        public Pessoa(IConta conta)
        {
            this._conta = conta;
        }
    }
}
