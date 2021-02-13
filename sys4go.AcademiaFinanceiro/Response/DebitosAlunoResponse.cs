using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sys4go.AcademiaFinanceiro.Response
{
    public class DebitosAlunoResponse
    {
        public int CodPagamento { get; set; }
        public string NomeAluno { get; set; }
        public DateTime DataCriada { get; set; }
        public DateTime DataVencimento { get; set; }
        public Decimal Valor { get; set; }
        public string Status { get; set; }
        public string TipoPagamento { get; set; }
    }
}
