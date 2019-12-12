using System.Collections.Generic;
using RoleTopMVC.Models;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.ViewModels
{
    public class UsuarioViewModel : BaseViewModel
    {
        public List<Evento> Eventos {get;set;}

        public List<TiposDeEvento> TiposDeEventos{get;set;}

        public List<ServicosAdicionais> ServicosAdicionais {get;set;}
        public Cliente Cliente {get;set;}

        public string NomeCliente {get;set;}

        public UsuarioViewModel()
        {
            
            this.ServicosAdicionais = new List<ServicosAdicionais>();
            this.TiposDeEventos = new List<TiposDeEvento>();
            this.Cliente = new Cliente();
            this.NomeCliente = "Amigo";
        }
    }

}