using System;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Models
{
    public class Evento
    {

        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}

        public string Nome {get;set;}
        
        public TiposDeEvento TiposDeEvento {get;set;}

        public ServicosAdicionais ServicosAdicionais {get;set;}
        public DateTime DataEvento {get;set;}

        public DateTime DataDoEvento {get;set;}

        public DateTime Horario{get;set;}

        public string DescricaoEvento {get;set;}

        public string FormaDePagamento {get;set;}

        public uint Status {get;set;}

        public double Preco {get;set;}

        
    public Evento()
    {
        this.Cliente = new  Cliente();
        this.TiposDeEvento = new  TiposDeEvento();
        this.Id = 0 ;
        this.ServicosAdicionais = new ServicosAdicionais();
        this.Status = (uint) StatusEvento.PENDENTE;
        
    }

    }
}