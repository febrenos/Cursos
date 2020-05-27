using System.Collections.Generic;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.ViewModels
{
    public class PedidoViewModel : BaseViewModel
    {
        public List<Hamburguer> Hamburgueres {get;set;}
        public List<Shake> Shake {get;set;} // {get;set;} pega o conjunto de informação do shake e aplica na lista 
        public Cliente Cliente {get;set;}
        public string NomeCliente {get;set;}

        public PedidoViewModel()
        {
            this.Hamburgueres = new List<Hamburguer>(); // da uma lista vazia para o usuário nao fzr merda
            this.Shake = new List<Shake>();
            this.Cliente = new Cliente(); // o cliente nasce com o pedido vazio
            this.NomeCliente = "Jovem";
        }
    }

}