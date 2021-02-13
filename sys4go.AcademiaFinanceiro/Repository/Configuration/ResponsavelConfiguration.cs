using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sys4go.AcademiaFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sys4go.AcademiaFinanceiro.Repository.Configuration
{
    public class ResponsavelConfiguration : IEntityTypeConfiguration<ResponsavelAlunoModel>
    {
        public void Configure(EntityTypeBuilder<ResponsavelAlunoModel> builder)
        {
            builder.ToTable("Responsavel");
            builder.HasKey(bc => new { bc.CodResponsavel });

        }
    }
}
