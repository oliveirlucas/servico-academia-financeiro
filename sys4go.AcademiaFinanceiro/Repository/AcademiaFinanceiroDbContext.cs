using Microsoft.EntityFrameworkCore;
using sys4go.AcademiaFinanceiro.Extensions;
using sys4go.AcademiaFinanceiro.Model;
using sys4go.AcademiaFinanceiro.Repository.Configuration;

namespace sys4go.AcademiaFinanceiro.Repository
{
    public class AcademiaFinanceiroDbContext : DbContext
    {
        public DbSet<PlanosModel> Planos { get; set; }
        public DbSet<AlunoModel> Aluno { get; set; }
        public DbSet<ResponsavelAlunoModel> Responsavel { get; set; }
        public DbSet<PagamentoModel> Pagamento { get; set; }

        public AcademiaFinanceiroDbContext(DbContextOptions<AcademiaFinanceiroDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PlanosConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AlunoConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ResponsavelConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PagamentoConfiguration).Assembly);

            foreach (Microsoft.EntityFrameworkCore.Metadata.IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.GetTableName().ConverterParaSnakeCase());

                foreach (Microsoft.EntityFrameworkCore.Metadata.IMutableProperty property in entity.GetProperties())
                {
                    property.SetColumnName(property.GetColumnName().ConverterParaSnakeCase());
                }

                foreach (Microsoft.EntityFrameworkCore.Metadata.IMutableKey key in entity.GetKeys())
                {
                    key.SetName(key.GetName().ConverterParaSnakeCase());
                }

                foreach (Microsoft.EntityFrameworkCore.Metadata.IMutableForeignKey key in entity.GetForeignKeys())
                {
                    key.SetConstraintName(key.GetConstraintName().ConverterParaSnakeCase());
                }

                foreach (Microsoft.EntityFrameworkCore.Metadata.IMutableIndex index in entity.GetIndexes())
                {
                    index.SetName(index.GetName().ConverterParaSnakeCase());
                }
            }
        }
    }
}
