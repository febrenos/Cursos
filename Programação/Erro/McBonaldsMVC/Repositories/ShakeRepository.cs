using System;
using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class ShakeRepository
    {
        private const string PATH = "Database/Shake.csv"; //tem que colocar get;set; para acesssar private
        public double ObterPrecoDe(string nomeShake)
        {
            var lista = ObterTodos(); //variavel lista = armazena as informaçoes
            var preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nomeShake)) // sde o nome que o ususario digitar for igual
                {
                    preco = item.Preco;
                    break;
                }
            }
                return preco;
        }
        public List <Shake> ObterTodos()
        {
            List<Shake> shake = new List <Shake>();
            
            string[] linhas = File.ReadAllLines(PATH);
            foreach(var linha in linhas)
            {
                Shake s = new Shake();
                string[] dados = linha.Split(";");
                s.Nome = dados[0];
                s.Preco = double.Parse(dados[1]);
                shake.Add(s);
            }
            return shake;
        }
    }
}