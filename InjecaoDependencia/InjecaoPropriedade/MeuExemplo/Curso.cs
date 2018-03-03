using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoPropriedade.MeuExemplo
{
    public class Curso
    {
        public Curso() { }

        private IDisciplina myDisciplina;

        public IDisciplina Disciplina
        {
            get{if (myDisciplina == null)
                {

                }
                return myDisciplina;
            }
            set { myDisciplina = value; }
        }
    }
}
