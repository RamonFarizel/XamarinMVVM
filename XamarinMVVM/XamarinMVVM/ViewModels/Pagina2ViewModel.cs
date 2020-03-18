using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMVVM.ViewModels.Base;

namespace XamarinMVVM.ViewModels
{
    public class Pagina2ViewModel : BaseViewModel
    {
        private string _mensagem = string.Empty;
        public string Mensagem { get => _mensagem; set => SetProperty(ref _mensagem,value); }

        public ICommand NavegarCommand { get; }

        public Pagina2ViewModel()
        {
            NavegarCommand = new Command(async () => await ExecutarNavegarCommand());
        }

        private async Task ExecutarNavegarCommand()
        {
            await Navigation.PopAsync(Mensagem);
        }
    }
}
