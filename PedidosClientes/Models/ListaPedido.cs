using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCarros
{
    public class ListaPedido
    // Lista que reúne todos os produtos do cliente
    {
        public List<Produtos> Pedido { get; set; }

        public void AdicionarProduto(Produtos pedido)
        {
            Pedido?.Add(pedido);
        }
        public List<Produtos> Pagos { get; set; }
        public void Pago(Produtos pedidoPago)
        {
            Console.Write("O PEDIDO ESTÁ PAGO? ");
            string confirmar = Console.ReadLine();
            if (confirmar == "S")
            {
                Console.WriteLine("PRODUTO PAGO*");
                Pagos?.Add(pedidoPago);
            }
            if (confirmar == "N")
            {
                return;
            }
        }

    }
}