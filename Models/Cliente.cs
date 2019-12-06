using System;

namespace RoleTopMVC.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Telefone{get;set;}
        public string Senha{get;set;}
        public string Email{get;set;}
        public string ConfirmaSenha {get;set;}

        public DateTime DataNascimento {get;set;}

        public uint TipoUsuario {get;set;}

        public Cliente()
        {

        }

        public Cliente(string nome, string telefone, string senha, string email, string confirmaSenha, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.ConfirmaSenha = confirmaSenha;
            this.Telefone = telefone;
            this.DataNascimento = dataNascimento;
        }
    }
}