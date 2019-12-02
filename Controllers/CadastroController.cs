using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : AbstratcController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public  IActionResult index()
        {
            return View();
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro" ;
            try 
            {
                Cliente cliente = new Cliente(
                    form["nome"],
                    form["telefone"],
                    form ["senha"], 
                    form["email"], 
                    DateTime.Parse(form["data-nascimento"]));
                
                clienteRepository.Inserir(cliente);

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