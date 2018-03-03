using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoConstrutor.MeuExemplo
{
    public class Curso
    {
        private Disciplina disciplina;

        public Curso(Disciplina myDisciplina)
        {
            disciplina = myDisciplina;
        }

        public void ObterDisciplina(Disciplina disciplina)
        {
            
        }
    }
}
