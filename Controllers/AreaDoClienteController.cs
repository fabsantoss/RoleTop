using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class AreaDoClienteController : Controller
    {
        
        public IActionResult EventoCadastro()
        {
            ViewData["NomeView"] = "Evento";
            return View();
        }
        //Não esquecer de continuar essa parte// 
    }
}