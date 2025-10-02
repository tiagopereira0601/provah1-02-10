using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.MicrosoftExtensions;
using System.ComponentModel.DataAnnotations;

namespace provah1.Controllers
{
    public class Projeto : Controller
    {
        public string Nome { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        [MinLength(3, ErrorMessage = "Nome deve ter no mínimo 3 caracteres")]
        [MaxLength(50, ErrorMessage = "Nome deve ter no máximo 50 caracteres")]

        public int Turma { get; set; }
        [Required(ErrorMessage = "Número da turma é obrigatório")]
        [(1,8, ErrorMessage = "O número tem que estar entre 1 e 8")]
        public string Descricao { get; set; }
        [MinLength(500, ErrorMessage = "Nome deve ter no máximo 500 caracteres")]

        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        public int NmroProjeto { get; set; }
        [Required(ErrorMessage = "Número do projeto é obrigatório")]
        [(10,99, ErrorMessage = "O número tem que estar entre 10 e 99")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
