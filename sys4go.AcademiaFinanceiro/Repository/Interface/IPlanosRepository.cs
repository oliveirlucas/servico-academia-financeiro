using sys4go.AcademiaFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sys4go.AcademiaFinanceiro.Repository.Interface
{
    public interface IPlanosRepository
    {
        List<PlanosModel> ObterPlanos();
    }
}
