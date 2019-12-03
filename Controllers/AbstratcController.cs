using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace RoleTopMVC.Controllers
{
    public class AbstratcController : Controller
    {
        protected const string SESSION_CLIENTE_EMAIL = "cliente_email";
        protected const string SESSION_CLIENTE_NOME = "nome_cliente";
        protected string ObterUsuarioSession()
        {
            var email =  HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            if(!string.IsNullOrEmpty(email))
            {
                return email;
            }
            else
            {
                return "";
            }
        }

        protected string ObterUsuarioNomeSession()
        {
            var nome = HttpContext.Session.GetString(SESSION_CLIENTE_NOME);
            if(!string.IsNullOrEmpty(nome))
            {
                return nome;
            }
            else
            {
                return "";
            }
        
        }
    }
}