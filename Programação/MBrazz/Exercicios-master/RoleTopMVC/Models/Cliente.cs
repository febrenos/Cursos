using System;

namespace RoleTopMVC.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}

        public Cliente()
        {

        }

        public Cliente(string nome, string senha, string email)
        {
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
        }
        
    }
}