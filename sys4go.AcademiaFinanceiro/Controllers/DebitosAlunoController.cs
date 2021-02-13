using Microsoft.AspNetCore.Mvc;
using sys4go.AcademiaFinanceiro.Response;
using sys4go.AcademiaFinanceiro.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sys4go.AcademiaFinanceiro.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DebitosAlunoController : ControllerBase
    {
        private readonly IDebitosAlunoService _debitosAlunoService;
        public DebitosAlunoController(IDebitosAlunoService debitosAlunoService)
        {
            _debitosAlunoService = debitosAlunoService;
        }
        [HttpGet("{matricula}")]
        public IActionResult ObterDebitosAluno(int matricula)
        {
            List<DebitosAlunoResponse> debitosAluno = _debitosAlunoService.ObterDebitosAluno(matricula);
            return Ok(debitosAluno);
        }
    }
}
