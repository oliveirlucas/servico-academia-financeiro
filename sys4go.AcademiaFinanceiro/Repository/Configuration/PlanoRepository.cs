using Microsoft.EntityFrameworkCore;
using sys4go.AcademiaFinanceiro.Model;
using sys4go.AcademiaFinanceiro.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace sys4go.AcademiaFinanceiro.Repository.Configuration
{
    public class PlanoRepository : ServicoAcademiaFinanceiroRepository<PlanosModel>, IPlanosRepository
    {
        private readonly DbContext _context;
        public PlanoRepository(DbContext context)
            : base(context)
        {
            this._context = context;
        }
        public List<PlanosModel> ObterPlanos()
        {
            return GetQueryable().ToList();
        }
    }
}
