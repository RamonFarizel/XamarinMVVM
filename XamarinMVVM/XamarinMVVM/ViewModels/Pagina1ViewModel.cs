using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMVVM.ViewModels.Base;

namespace XamarinMVVM.ViewModels
{
    public class Pagina1ViewModel : BaseViewModel
    {
        public ICommand NavegarCommand { get; }

        public Pagina1ViewModel()
        {
            NavegarCommand = new Command<object>(async (obj) => await ExecutarNavegarCommand(obj));
        }

        public override Task InitializeAsync(object[] args)
        {
            Title = (string)args[0];

            return base.InitializeAsync(args);
        }

        public override Task ReturnedAsync(object[] args)
        {
            Title = (string)args[0];
            return base.ReturnedAsync(args);
        }

        private async Task ExecutarNavegarCommand(object obj)
        {
            if ((string)obj == "True")
                await Navigation.PushAsync<Pagina2ViewModel>();
            else

                await Navigation.PopAsync(Title);
        }

    }
}
