using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidosController : AbstractController // herança 
    {
        
        ClienteRepository clienteRepository = new ClienteRepository ();
        PedidoRepository pedidoRepository = new PedidoRepository();
        HamburguerRepository hamburguerRepository = new HamburguerRepository ();
        ShakeRepository shakeRepository = new ShakeRepository ();

        public IActionResult Index()
        {
            PedidoViewModel pedidos = new PedidoViewModel(); // pvm pedido view model 
            pedidos.Hamburgueres = hamburguerRepository.ObterTodos();
            pedidos.Shake = shakeRepository.ObterTodos();

            var emailCliente = ObterUsuarioSession();
            if(!string.IsNullOrEmpty(emailCliente))
            {
                pedidos.Cliente = clienteRepository.ObterPor(emailCliente);
            }

            var nomeUsuario = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuario))
            {
                pedidos.NomeCliente = nomeUsuario;
            }
            
            pedidos.NomeView ="Pedido";
            pedidos.UsuarioEmail = ObterUsuarioSession();
            pedidos.UsuarioNome = ObterUsuarioNomeSession();

            
            return View(pedidos);
        }

        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"] = "Pedido";
            Pedido pedido = new Pedido();

            
            // Shake shake = new Shake();
            // pedido.Shake = shake;
            // shake.Nome = form["shake"];
            // shake.Preco = 0.0;


            // Hamburguer hamburguer = new Hamburguer();
            // hamburguer.Nome = form["hamburguer"];                // msm coisa 
            // hamburguer.Preco = 0.0;




            var nomeHamburguer = form["hamburguer"];
            Hamburguer hamburguer = new Hamburguer(
                nomeHamburguer,
                hamburguerRepository.ObterPrecoDe(nomeHamburguer)); // construtor // separaçao das informaçoes em obj

            pedido.Hamburguer = hamburguer;

            var nomeShake = form["shake"];
            Shake shake = new Shake(
                nomeShake,
                shakeRepository.ObterPrecoDe(nomeShake));



            
            Cliente cliente = new Cliente();
                cliente.Nome =     form     ["nome"];
                cliente.Endereco = form     ["endereco"];
                cliente.Telefone = form     ["telefone"];
                cliente.Email =    form     ["email"];
            
            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            // pedido.Precototal = 0.0;

            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;

            if(pedidoRepository.Inserir(pedido)){
                return View("sucesso");
            } else {
                return View("Erro");
            }
        }
    }
}
