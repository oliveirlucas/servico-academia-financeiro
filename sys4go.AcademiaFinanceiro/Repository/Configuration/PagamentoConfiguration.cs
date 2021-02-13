using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sys4go.AcademiaFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sys4go.AcademiaFinanceiro.Repository.Configuration
{
    public class PagamentoConfiguration : IEntityTypeConfiguration<PagamentoModel>
    {
        public void Configure(EntityTypeBuilder<PagamentoModel> builder)
        {
            builder.ToTable("Pagamento");
            builder.HasKey(bc => new { bc.CodPagamento , bc.CodAluno});
            builder.HasOne(bc => bc.Aluno)
                .WithMany(b => b.Pagamento)
                .HasForeignKey(bc => bc.CodAluno);

        }
    }
}
