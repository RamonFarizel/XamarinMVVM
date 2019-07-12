using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMVVM.ViewModels.Base;

namespace XamarinMVVM.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private string _nome = string.Empty;
        public string Nome
        {
            get { return _nome; }
            set {SetProperty(ref(_nome), value); }
        }

        public ICommand AlterarNome { get; set; }

       public MainPageViewModel()
        {
            Nome = "Ramon";
            AlterarNome = new Command(AlterandoNome);
        }

        private void AlterandoNome()
        {
            Nome = "Ramon";
        }
    }
}
