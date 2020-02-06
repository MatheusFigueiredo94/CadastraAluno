using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastraNotaAluno.Entidade
{
    public class Aluno
    {
        public Aluno(string nomeAluno, DateTime dataNascimento, string sexo)
        {
            NomeAluno = nomeAluno;
            DataNascimento = dataNascimento;
            Sexo = sexo;
        }

        public int Id { get; private set; }

        public string NomeAluno { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public string Sexo { get; private set; }
    }
}
