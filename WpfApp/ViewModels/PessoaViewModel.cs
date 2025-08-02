using WpfApp.Models;
using WpfApp.Utilities;

namespace WpfApp.ViewModels
{
    public class PessoaViewModel : ViewModelBase
    {
        private readonly PessoaModel _pessoaModel;

        public int Id
        {
            get { return _pessoaModel.Id; }
            set { _pessoaModel.Id = value; OnPropertyChanged(); }
        }

        public string Nome
        {
            get { return _pessoaModel.Nome; }
            set { _pessoaModel.Nome = value; OnPropertyChanged(); }
        }

        public string Cpf
        {
            get { return _pessoaModel.Cpf; }
            set { _pessoaModel.Cpf = value; OnPropertyChanged(); }
        }

        public string Endereco
        {
            get { return _pessoaModel.Endereco; }
            set { _pessoaModel.Endereco = value; OnPropertyChanged(); }
        }

        public PessoaViewModel()
        {
            _pessoaModel = new PessoaModel();
        }
    }
}
