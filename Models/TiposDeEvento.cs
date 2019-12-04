using System;

namespace RoleTopMVC.Models
{
    public class TiposDeEvento : Evento
    {
    
    public TiposDeEvento()
    {

    }

    public TiposDeEvento(string nome, double preco)
    {
        this.Nome = nome;
        this.Preco = preco;
    }

        
    }

}