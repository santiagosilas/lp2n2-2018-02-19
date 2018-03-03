using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoConstrutor.MeuExemplo
{
    public class Disciplina : IDisciplina
    {
        public int TotalDisciplina() => 0;

        void GetDisciplina(Disciplina disciplina)
        {
            throw new NotImplementedException();
        }
    }

    public interface IDisciplina
    {
        int TotalDisciplina();
    }
}
