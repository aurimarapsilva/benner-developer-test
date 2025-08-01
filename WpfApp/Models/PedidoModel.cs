using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Helpers;

namespace WpfApp.Models
{
    public class PedidoModel
    {
        public int Id { get; set; }
        public PedidoModel Pessoa { get; set; }
        public List<ItemPedidoModel> Produtos { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataVenda { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public StatusPedido Status { get; set; }
    }
}
