using sys4go.AcademiaFinanceiro.Model;
using sys4go.AcademiaFinanceiro.Repository.Interface;
using sys4go.AcademiaFinanceiro.Response;
using sys4go.AcademiaFinanceiro.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sys4go.AcademiaFinanceiro.Services
{
    public class DebitosAlunoService : IDebitosAlunoService
    {
        private readonly IDebitosAlunoRepository _debitosAlunoRepository;
        public DebitosAlunoService(IDebitosAlunoRepository debitosAlunoRepository)
        {
            _debitosAlunoRepository = debitosAlunoRepository;
        }

        public List<DebitosAlunoResponse> ObterDebitosAluno(int matricula)
        {
            List<ResponsavelAlunoModel> debitosAluno = _debitosAlunoRepository.ObterDebitosDoAluno(matricula);
            var alunoFinanceiro = PopularDebitos(debitosAluno);

            return alunoFinanceiro;
        }

        public List<DebitosAlunoResponse> PopularDebitos(List<ResponsavelAlunoModel> debitosAluno)
        {
            List<DebitosAlunoResponse> titulosAluno = new List<DebitosAlunoResponse>();

            foreach(var debitos in debitosAluno)
            {
                titulosAluno.Add(new DebitosAlunoResponse{ 
                });;
            }
            return titulosAluno;
        }
    }
}
