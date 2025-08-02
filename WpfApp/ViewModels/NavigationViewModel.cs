using System.Windows.Input;
using WpfApp.Utilities;

namespace WpfApp.ViewModels
{
    public class NavigationViewModel : ViewModelBase
    {
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand PedidoCommand { get; set; }
        public ICommand PessoaCommand { get; set; }
        public ICommand ProdutoCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeViewModel();
        private void Pedido(object obj) => CurrentView = new PedidoViewModel();
        private void Pessoa(object obj) => CurrentView = new PessoaViewModel();
        private void Produto(object obj) => CurrentView = new ProdutoViewModel();

        public NavigationViewModel()
        {
            HomeCommand = new RelayCommand(Home);
            PedidoCommand = new RelayCommand(Pedido);
            PessoaCommand = new RelayCommand(Pessoa);
            ProdutoCommand = new RelayCommand(Produto);

            // Startup Page
            CurrentView = new HomeViewModel();
        }
    }
}
