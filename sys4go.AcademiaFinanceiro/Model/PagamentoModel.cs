using System;

namespace sys4go.AcademiaFinanceiro.Model
{
    public class PagamentoModel
    {
        public int CodPagamento { get; set; }
        public AlunoModel Aluno { get; set; }
        public DateTime DataCriada { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Status { get; set; }
        public string TipoPagamento { get; set; }
        public Decimal Valor { get; set; }
        public DateTime DataRegistro { get; set; }

    }
}
