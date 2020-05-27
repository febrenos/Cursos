using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using McBonaldsMVC.Controllers;
using McBonaldsMVC.ViewModels;
using MCBonaldsMVC.ViewModels;

namespace McBonaldsMVC.Controlllers
{
    public class CadastroController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index()
        {
            return View(new BaseViewModel() // esse view vem de controller , ele é herdado 
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        
        public IActionResult CadastrarCliente(IFormCollection form)
        {
            try
            {
                Cliente cliente = new Cliente(
                    form["nome"],
                    form["endereço"],
                    form["telefone"],
                    form["senha"],
                    form["email"],
                    DateTime.Parse(form["data-nascimento"]));

                    clienteRepository.Inserir(cliente);

                return View ("Sucesso", new RespostaViewModel(){
                    NomeView = "Cadastro"
                });
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel(){
                    NomeView = "Cadastro"
                });
            }
        }
    }
}