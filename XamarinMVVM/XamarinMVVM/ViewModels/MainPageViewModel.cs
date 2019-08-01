using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMVVM.Services;
using XamarinMVVM.ViewModels.Base;
using XamarinMVVM.Views;

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

        private async void AlterandoNome()
        {
            Dictionary<string, string> Param = new Dictionary<string, string>();
            Param.Add("Nome", Nome);

            await Navigation.PushAsync<Page1ViewModel>(false,Param);
           
        }
    }
}
