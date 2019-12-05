using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class QuemSomosController : Controller
    {
        public IActionResult informacoes()
        {
            return View(new BaseViewModel()
            {
            NomeView = "QuemSomos"
            });
        }
    }
}