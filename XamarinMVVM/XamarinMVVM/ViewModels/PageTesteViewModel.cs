using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMVVM.ViewModels.Base;

namespace XamarinMVVM.ViewModels
{
    public class PageTesteViewModel: BaseViewModel
    {
        public ICommand NavegarCommand { get; }

        public PageTesteViewModel()
        {
            NavegarCommand = new Command(async () => await ExecuteNavegarCommand());
        }

        public override Task InitializeAsync(object[] args)
        {
            Title = "Navegação Page teste";
            
            return base.InitializeAsync(args);
        }

        private async Task ExecuteNavegarCommand()
        {
            await Navigation.PopAsync(null);
        }
    }
}
