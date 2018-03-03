using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoFramework.MeuExemplo
{
    public class Disciplina : IDisciplina
    {
        public string ListarDisciplina()
        {
            return null;
        }
    }

    public interface IDisciplina
    {
        string ListarDisciplina();
    }
}
