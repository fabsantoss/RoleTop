using System;
using System.Collections.Generic;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Models
{
    public class Evento
    {

        public ulong Id {get;set;}
        public Cliente Cliente {get;set;
        }
        public List<TiposDeEvento> TiposDeEvento {get;set;}

        public DateTime DataEvento {get;set;}

        public string DataDoEvento {get;set;}

        public string DescricaoEvento {get;set;}

        public string FormaDePagamento {get;set;}

        public uint Status {get;set;}
        public List<ServicosAdicionais> ServicosAdicionais {get;set;}

        
    public Evento()
    {
        this.Cliente = new  Cliente();
        this.TiposDeEvento =  new List<TiposDeEvento>();
        this.Id = 0 ;
        this.DataDoEvento =  DataDoEvento;
        this.DescricaoEvento = DescricaoEvento;
        this.FormaDePagamento = FormaDePagamento;
        this.ServicosAdicionais = ServicosAdicionais;
        this.Status = (uint) StatusEvento.PENDENTE;
    }

    }
}