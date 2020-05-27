using System;
using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class PedidoRepository : RepositoryBase
    {
        private const string PATH = "Database/Pedido.csv";
        public PedidoRepository()
        {
            if (!File.Exists(PATH)){
                File.Create(PATH).Close ();

            }
        }
        public bool Inserir(Pedido pedido){
            var quantidadepedidos = File.ReadAllLines(PATH).Length; //ReadAllLines= le as linhas, Length devolve cada linha do vetor -> esse metodo vai direto ao ponto
            pedido.Id = (ulong) ++quantidadepedidos;
            var linha = new string[] {PrepararPedidosCSV (pedido) };
            File.AppendAllLines(PATH, linha);

            return true;
        }
        public List<Pedido> ObterTodosPorCliente(string emailCliente)
        {
            var pedidos = ObterTodos();
            List<Pedido> pedidosCliente = new List<Pedido>();
            foreach(var pedido in pedidos)
            {
                if(pedido.Cliente.Email.Equals(emailCliente))
                {
                    pedidosCliente.Add(pedido);
                }
            }
            return pedidosCliente;
        }
        public List<Pedido> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Pedido> pedidos = new List<Pedido>();
            foreach(var linha in linhas)
            {
                Pedido pedido = new Pedido();

                pedido.Id = ulong.Parse(ExtrairValorDoCampo("id" , linha));
                pedido.Status =uint.Parse(ExtrairValorDoCampo("status_pedido", linha));
                pedido.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                pedido.Cliente.Nome = ExtrairValorDoCampo("cliente_endereco", linha);
                pedido.Cliente.Nome = ExtrairValorDoCampo("cliente_telefone", linha);
                pedido.Cliente.Nome = ExtrairValorDoCampo("cliente_email", linha);
                pedido.Hamburguer.Nome = ExtrairValorDoCampo("hamburguer_nome", linha);
                pedido.Hamburguer.Preco = double.Parse(ExtrairValorDoCampo("hamburguer_nome", linha));
                pedido.Shake.Nome = ExtrairValorDoCampo("shake_nome", linha);
                pedido.Shake.Preco = double.Parse(ExtrairValorDoCampo("shake_nome", linha));
                pedido.PrecoTotal = double.Parse(ExtrairValorDoCampo("shake_nome", linha));
                pedido.DataDoPedido = DateTime.Parse(ExtrairValorDoCampo("shake_nome", linha));

                pedidos.Add(pedido);
            }
            return pedidos;

        }

        private string PrepararPedidosCSV(Pedido pedido)
        {
            Cliente c = pedido.Cliente;      //c = cliente
            Hamburguer h = pedido.Hamburguer;//h = hamburguer
            Shake s = pedido.Shake;          //s = shake

            return $"id={pedido.Id};status_pedido={pedido.Status};cliente_nome={c.Nome};cliente_endereco={c.Endereco};cliente_telefone={c.Telefone};cliente_email={c.Email};hamburguer_nome+{h.Nome};hamburguer_precp={h.Preco};shake_nome{s.Nome};shake_preco={s.Preco};data_pedido={pedido.DataDoPedido};preco_total={pedido.PrecoTotal}"; 
        }
    }
}