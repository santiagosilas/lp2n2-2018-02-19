using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoInterface.MeuExemplo
{
    public class Curso
    {
        private readonly IDisciplina _disciplina;

        public Curso(IDisciplina disciplina)
        {
            this._disciplina = disciplina;
        }

        public string Listar()
        {
            return this._disciplina.Listar();
        }
    }
}
