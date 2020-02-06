using CadastraNotaAluno.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastraNotaAluno.Data.Context.EntityConfig
{
    public class AlunoConfig : EntityTypeConfiguration<Aluno>
    {
        public AlunoConfig()
        {
            ToTable("ALUNO", "DBO");

            HasKey(u => u.Id);
            Property(u => u.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(u => u.Id).HasColumnName("ID_ALUNO");
            Property(u => u.NomeAluno).HasColumnName("DS_NOME_ALUNO");
            Property(u => u.DataNascimento).HasColumnName("DT_NASCIMENTO");
            Property(u => u.Sexo).HasColumnName("IE_SEXO");

        }
    }
}
