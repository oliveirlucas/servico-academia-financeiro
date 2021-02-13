using Microsoft.EntityFrameworkCore;
using sys4go.AcademiaFinanceiro.Model;
using sys4go.AcademiaFinanceiro.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sys4go.AcademiaFinanceiro.Repository
{
    public class DebitosAlunoRepository : ServicoAcademiaFinanceiroRepository<ResponsavelAlunoModel> , IDebitosAlunoRepository
    {
        public DebitosAlunoRepository(DbContext context)
            : base(context)
        {
        }

        public List<ResponsavelAlunoModel> ObterDebitosDoAluno(int matricula)
        {
            var result = GetQueryable()
                .ToList();
            return result;
        }
    }
}
