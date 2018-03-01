using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoInterface.MeuExemplo
{
    public class Curso
    {
        public IList<Disciplina> ListDisciplina()
        {
            Disciplina disciplina = new Disciplina();
            IList<Disciplina> disc = disciplina.GetAllDisciplina();
            return disc;
        }
    }
}
