using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoInterface.MeuExemplo
{
    public class Disciplina 
    {
        public IList<Disciplina> GetAllDisciplina()
        {
            return new List<Disciplina>();
        }
    }
}
