using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using McBonaldsMVC.Controllers;
using Microsoft.AspNetCore.Mvc;
using McBonaldsMVC.Enums;

namespace McBonaldsMVC.Controllers
{
    public class AdiministradorController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();
        public IActionResult Deshboard()
        {
            var pedidos = pedidoRepository.ObterTodos();
            DashboardViewModel dashboardViewModel = new DashboardViewModel();

        foreach (var pedido in pedidos)
        {
            switch(pedido.Status)
            {
                case (uint)StatusPedido.APROVADO:
                    dashboardViewModel.PedidosAprovados++;
                break;
                case (uint)StatusPedido.REPROVADO:
                    dashboardViewModel.PedidosReprovados++;
                break;
                default:
                    dashboardViewModel.PedidosPendentes++;
                    dashboardViewModel.Pedidos.Add(pedido);
                break;
                


            }
        }
        dashboardViewModel.NomeView = "Deshboard";
        dashboardViewModel.UsuarioEmail = ObterUsuarioSession();
            return View(dashboardViewModel);
        }
    }
}