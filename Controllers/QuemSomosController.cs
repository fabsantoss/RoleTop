using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class QuemSomosController : Controller
    {
        public IActionResult informacoes()
        {
            ViewData["NomeView"] = "QuemSomos";
            return View();
        }
    }
}