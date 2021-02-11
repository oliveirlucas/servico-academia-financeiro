using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sys4go.AcademiaFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sys4go.AcademiaFinanceiro.Repository.Configuration
{
    public class PlanosConfiguration : IEntityTypeConfiguration<PlanosModel>
    {
        public void Configure(EntityTypeBuilder<PlanosModel> builder)
        {
            builder.ToTable("Planos");
            builder.HasKey(bc => new { bc.CodPlano });
        }
    }
}
