using CadastraNotaAluno.Data.Context;
using CadastraNotaAluno.Data.Repositorio;
using CadastraNotaAluno.Entidade;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CadastraNotaAluno.Negocios
{
    public class AlunoNegocios
    {        

        public void Cadastrar(Aluno aluno)
        {

            BaseRepository<Aluno> baseAluno = new BaseRepository<Aluno>();

            baseAluno.Cadastrar(aluno);

        }


    }
}
