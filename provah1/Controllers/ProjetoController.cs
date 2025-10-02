using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace provah1.Controllers
{
    public class ProjetoController : Controller
    {
        private static List<Visita> visitaAlunos = new List<Visita>();

        [ApiController]

        public class Visita

        {
            [Required]
            public string RAAluno { get; set; }
            public DateTime DataVisita { get; set; }
            public int NmroProjeto { get; set; }
        }

        [HttpPost]
        [Route("Inserir")]
        public IActionResult Inserir(Visita visita)
        {
            visitaAlunos.Add(visita);
            return Ok($"Visita {visita} adicionada com sucesso");
        }



        [HttpGet]
        [Route("Obter todas")]
        public IActionResult ObterTodas(Visita visita)
        {
            return Ok(visita);

        }
    }
}

