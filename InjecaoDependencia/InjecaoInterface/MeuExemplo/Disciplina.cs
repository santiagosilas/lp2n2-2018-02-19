﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoInterface.MeuExemplo
{
    public class Disciplina : IDisciplina 
    {
        public string Listar()
        {
            return null;
        }
    }

    public interface IDisciplina
    {
        string Listar();
    }
}
