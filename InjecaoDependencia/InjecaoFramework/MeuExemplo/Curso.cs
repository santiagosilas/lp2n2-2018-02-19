using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoFramework.MeuExemplo
{
    public class Curso
    {
        private readonly IDisciplina _disciplina;

        public Curso(IDisciplina disciplina)
        {
            this._disciplina = disciplina;
        }

        public string ListarDisciplina()
        {
            return this._disciplina.ListarDisciplina();
        }
    }
}
