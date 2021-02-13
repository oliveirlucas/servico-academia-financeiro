using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sys4go.AcademiaFinanceiro.Model
{
    public class ResponsavelAlunoModel
    {
        public int CodResponsavel { get; set; }
        public string NomResponsavel { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public DateTime DataRegistro { get; set; }
        public ICollection<AlunoModel> Aluno { get; set; }
    }
}
