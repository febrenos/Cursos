using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers {
    public class CadastroController : AbstractController {

        ClienteRepository clienteRepository = new ClienteRepository ();
        public IActionResult Index () {
            return View (new BaseViewModel () {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            }
            );
        }

        public IActionResult CadastrarCliente (IFormCollection form) {
            Cliente cliente = new Cliente();
            ViewData["Action"] = "Cadastro";
            try {
                cliente = new Cliente (form["nome"], form["endereco"], form["telefone"], form["senha"], form["email"], DateTime.Parse (form["data-nascimento"]));

                clienteRepository.Inserir (cliente);

                return View ("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    Mensagem = $"{cliente.Nome} seu cadastro foi concluído!"
                });

            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    Mensagem = $"{cliente.Nome} seu cadastro foi concluído!"
                });
            }
        }
    }
}