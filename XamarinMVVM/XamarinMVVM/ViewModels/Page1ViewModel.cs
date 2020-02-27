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
        public ICommand VoltarCommand { get; }

        public Page1ViewModel()
        {
            Title = "Page1";
            VoltarCommand = new Command(async () => await ExecuteNavegarCommand());
        }

        private async Task ExecuteNavegarCommand()
        {
            await Navigation.PopAsync();
        }
    }
}
