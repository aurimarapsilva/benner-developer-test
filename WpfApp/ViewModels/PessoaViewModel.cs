using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Models;

namespace WpfApp.ViewModels
{
    public class PessoaViewModel : Utilities.ViewModelBase
    {
        private readonly PessoaModel _pessoaModel;

        public int Id
        {
            get { return _pessoaModel.Id; }
            set { _pessoaModel.Id = value;  OnPropertyChanged(); }
        }

        public string Nome
        {
            get { return _pessoaModel.Nome; }
            set { _pessoaModel.Nome = value;  OnPropertyChanged(); }
        }

        public string Cpf
        {
            get { return _pessoaModel.Cpf; }
            set { _pessoaModel.Cpf = value;  OnPropertyChanged(); }
        }

        public string Endereco
        {
            get { return _pessoaModel.Endereco; }
            set { _pessoaModel.Endereco = value;  OnPropertyChanged(); }
        }
    }
}
