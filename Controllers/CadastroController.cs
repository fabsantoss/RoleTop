using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : Controller
    {
        public  IActionResult index()
        {
            return View();
        }

        public IActionResult CadastrarCliente(IFormCollection  form)
        {
            ViewData["Action"] = "Cadastro" ;
            try 
            {
                Cliente cliente = new Cliente(form["nome"], form["endereco"], form["telefone"], form ["senha"], form["email"], DateTime.Parse(form["data-nascimento"]));
                return View("Sucesso");

                
            }
            catch  (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
        }
    }
}