using Microsoft.AspNetCore.Mvc;

namespace SistemaBancario.Controllers
{
    public class BancoController : Controller
    {
        [HttpGet] // DETERMINA QUAL TIPO DE REQUISIÇÃO SERÁ NECESSÁRIA
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string tipoAcesso, string senha, string numeroConta)
        {
            return View();
        }

        [HttpGet]
        public IActionResult MinhaConta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RealizarTransacao(string numeroConta, string tipoAcao, decimal valor)
        {
            return View();
        }

        [HttpPost]

        public IActionResult PainelGerente()
        {
            return View();
        }
    }
}
