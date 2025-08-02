using System;
using System.Collections.Generic;
using WpfApp.Helpers;
using WpfApp.Models;
using WpfApp.Utilities;

namespace WpfApp.ViewModels
{
    public class PedidoViewModel : ViewModelBase
    {
        private readonly PedidoModel _pedidoModel;

        public int Id
        {
            get { return _pedidoModel.Id; }
            set { _pedidoModel.Id = value; OnPropertyChanged(); }
        }

        public PedidoModel Pessoa
        {
            get { return _pedidoModel.Pessoa; }
            set { _pedidoModel.Pessoa = value; OnPropertyChanged(); }
        }

        public List<ItemPedidoModel> Produtos
        {
            get { return _pedidoModel.Produtos; }
            set { _pedidoModel.Produtos = value; OnPropertyChanged(); }
        }

        public decimal ValorTotal
        {
            get { return _pedidoModel.ValorTotal; }
            set { _pedidoModel.ValorTotal = value; OnPropertyChanged(); }
        }

        public DateTime DataVenda
        {
            get { return _pedidoModel.DataVenda; }
            set { _pedidoModel.DataVenda = value; OnPropertyChanged(); }
        }

        public FormaPagamento FormaPagamento
        {
            get { return _pedidoModel.FormaPagamento; }
            set { _pedidoModel.FormaPagamento = value; OnPropertyChanged(); }
        }

        public StatusPedido Status
        {
            get { return _pedidoModel.Status; }
            set { _pedidoModel.Status = value; OnPropertyChanged(); }
        }

        public PedidoViewModel()
        {
            _pedidoModel = new PedidoModel();
        }
    }
}
