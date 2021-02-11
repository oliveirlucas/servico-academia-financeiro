using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sys4go.AcademiaFinanceiro.Model;
using sys4go.AcademiaFinanceiro.Repository;
using sys4go.AcademiaFinanceiro.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sys4go.AcademiaFinanceiro.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PlanosController : ControllerBase
    {
        private readonly IPlanosRepository _planosRepository;
        public PlanosController(IPlanosRepository planosRepository)
        {
            _planosRepository = planosRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<PlanosModel> planos = _planosRepository.ObterPlanos();
            return Ok(planos);
        }
    }
}
