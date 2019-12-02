using System;
using System.Collections.Generic;

namespace RoleTopMVC.Models
{
    public class Evento
    {
        public List<TiposDeEvento> TiposDeEvento {get;set;}
        public DateTime DataEvento {get;set;}

        public string DataDoEvento {get;set;}

        public string DescricaoEvento {get;set;}

        public string FormaDePagamento {get;set;}

        public string ServicosAdicionais {get;set;}
        
    public Evento()
    {
        this.TiposDeEvento =  new List<TiposDeEvento>();
        this.DataDoEvento =  DataDoEvento;
        this.DescricaoEvento = DescricaoEvento;
        this.FormaDePagamento = FormaDePagamento;
        this.ServicosAdicionais = ServicosAdicionais;
    }

    }
}