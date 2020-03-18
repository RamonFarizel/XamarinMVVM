using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMVVM.ViewModels.Base;

namespace XamarinMVVM.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand NavegarCommand { get; }

        public MainPageViewModel()
        {
            Title = "Teste Main Page";
            NavegarCommand = new Command(async () => await ExecutarNavegarCommand());
        }

        public override Task ReturnedAsync(object[] args)
        {
            if (args != null)
                Title = (string)args[0];

            return base.ReturnedAsync(args);
        }

        private async Task ExecutarNavegarCommand()
        {
            string texto = "Teste navegação";
            await Navigation.PushAsync<Pagina1ViewModel>(texto);
        }
    }
}
