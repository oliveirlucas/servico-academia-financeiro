using sys4go.AcademiaFinanceiro.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sys4go.AcademiaFinanceiro.Services.Interface
{
    public interface IDebitosAlunoService
    {
        List<DebitosAlunoResponse> ObterDebitosAluno(int matricula);
    }
}
