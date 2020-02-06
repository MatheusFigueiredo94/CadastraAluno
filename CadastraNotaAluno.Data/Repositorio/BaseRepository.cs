using CadastraNotaAluno.Data.Context;
using CadastraNotaAluno.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastraNotaAluno.Data.Repositorio
{
    public class BaseRepository<T> where T : class
    {
        public readonly CadastraNotaAlunoContext context;
        protected System.Data.Entity.IDbSet<T> dbSet;

        public BaseRepository()
        {
            context = new CadastraNotaAlunoContext();
            dbSet = context.Set<T>();
        }


        public void Cadastrar(T obj)
        {
         
            dbSet.Add(obj);

            context.SaveChanges();

        }

      


    }
}
