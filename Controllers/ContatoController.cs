using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult contato()
        {
            return View(new BaseViewModel()
            {
                NomeView ="Contato"
            });
        }
    }
}