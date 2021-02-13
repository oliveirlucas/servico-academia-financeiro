using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sys4go.AcademiaFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sys4go.AcademiaFinanceiro.Repository.Configuration
{
    public class AlunoConfiguration : IEntityTypeConfiguration<AlunoModel>
    {
        public void Configure(EntityTypeBuilder<AlunoModel> builder)
        {
            builder.ToTable("Aluno");
            builder.HasKey(bc => new { bc.CodAluno , bc.CodResponsavel});

            builder.HasOne(bc => bc.Responsavel)
                .WithMany(b => b.Aluno)
                .HasForeignKey(bc => bc.CodResponsavel);

        }
    }
}
