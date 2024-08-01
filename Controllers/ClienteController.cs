using Microsoft.AspNetCore.Mvc;

namespace Aula2407.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult CadastroCliente()
        {
            return View();
        }
    }
}
