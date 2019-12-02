using System;

namespace RoleTopMVC.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Telefone{get;set;}
        public string Senha{get;set;}
        public string Email{get;set;}

        public DateTime DataNascimento {get;set;}

        public Cliente()
        {

        }

        public Cliente(string nome, string telefone, string Senha, string email, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Senha = Senha;
            this.Email = email;
            this.DataNascimento = dataNascimento;
        }
    }
}