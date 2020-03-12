using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMVVM.ViewModels.Base;

namespace XamarinMVVM.ViewModels
{
    public class Page1ViewModel : BaseViewModel
    {
        public ICommand NavegarCommand { get; }

        public Page1ViewModel()
        {
            NavegarCommand = new Command(async () => await ExecuteNavegarCommand());
        }

        private async Task ExecuteNavegarCommand()
        {
            await Navigation.PushAsync<PageTesteViewModel>(false);
        }

        public override Task ReturnAsync(object[] args)
        {
            return base.ReturnAsync(args);
        }
    }
}
