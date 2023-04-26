using Microsoft.AspNetCore.Mvc;
using SistemaContas.Presentation.Models.Account;

namespace SistemaContas.Presentation.Controllers
{
    public class AccountController : Controller
    {
        //GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        //POST: /Account/Login
        [HttpPost] //Método para receber o SUBMIT POST do formulário
        public IActionResult Login(LoginViewModel model)
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult PasswordRecover()
        {
            return View();
        }

    }
}
