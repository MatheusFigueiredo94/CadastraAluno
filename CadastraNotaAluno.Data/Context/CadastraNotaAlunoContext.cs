using CadastraNotaAluno.Data.Context.EntityConfig;
using CadastraNotaAluno.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastraNotaAluno.Data.Context
{
    public class CadastraNotaAlunoContext : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlunoConfig());

            Database.SetInitializer<CadastraNotaAlunoContext>(null);
        }

    }
}
