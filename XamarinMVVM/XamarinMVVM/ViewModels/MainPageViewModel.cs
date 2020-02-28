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
        public ICommand NavegarCommand { get; }
        
        public MainPageViewModel()
        {
            NavegarCommand = new Command(async () => await ExecuteNavegarCommand());
            Title = "MainPage";
        }

        private async Task ExecuteNavegarCommand()
        {
            await Navigation.PushAsync<Page1ViewModel>(false,"Pagina1 Meu Filho");
        }
    }
}
