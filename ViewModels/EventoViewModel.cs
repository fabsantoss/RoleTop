using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class EventoViewModel :BaseViewModel
    {

        public List<TiposDeEvento> TiposDeEvento {get;set;}
        public Cliente cliente {get;set;}
        public string NomeCliente {get;set;}


        public EventoViewModel()
        {
            this.TiposDeEvento = new List<TiposDeEvento>();
            this.cliente = new Cliente();
            
        }
    }
}