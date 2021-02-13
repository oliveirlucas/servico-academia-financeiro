using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sys4go.AcademiaFinanceiro.Model
{
    public class DebitosAlunoModel
    {
        public int CodPagamento { get; set; }
        public int CodAluno { get; set; }
        public AlunoModel Aluno { get; set; }
        public DateTime DataCriada { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Status { get; set; }
        public string TipoPagamento { get; set; }
        public Decimal Valor { get; set; }
        public DateTime DataRegistro { get; set; }
        public PagamentoModel Pagamento { get; set; }
    }
}
