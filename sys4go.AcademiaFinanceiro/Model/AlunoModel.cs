﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sys4go.AcademiaFinanceiro.Model
{
    public class AlunoModel
    {
        public int CodAluno { get; set; }
        public int CodResponsavel { get; set; }
        public string NomAluno { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime Data { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Nivel { get; set; }
        public string Status { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public DateTime DataRegistro { get; set; }
        public string IndResponsavel { get; set; }
        public ResponsavelAlunoModel Responsavel { get; set; }
        public ICollection<PagamentoModel> Pagamento { get; set; }
    }
}
