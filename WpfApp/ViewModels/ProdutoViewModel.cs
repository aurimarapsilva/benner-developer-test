using WpfApp.Models;
using WpfApp.Utilities;

namespace WpfApp.ViewModels
{
    public class ProdutoViewModel : ViewModelBase
    {
        private readonly ProdutoModel _produtoModel;

        public int Id
        {
            get { return _produtoModel.Id; }
            set { _produtoModel.Id = value; OnPropertyChanged(); }
        }

        public string Nome
        {
            get { return _produtoModel.Nome; }
            set { _produtoModel.Nome = value; OnPropertyChanged(); }
        }

        public string Codigo
        {
            get { return _produtoModel.Codigo; }
            set { _produtoModel.Codigo = value; OnPropertyChanged(); }
        }

        public decimal Valor
        {
            get { return _produtoModel.Valor; }
            set { _produtoModel.Valor = value; OnPropertyChanged(); }
        }

        public ProdutoViewModel()
        {
            _produtoModel = new ProdutoModel();
        }
    }
}
