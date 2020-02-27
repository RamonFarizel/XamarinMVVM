using System;
using System.Threading.Tasks;
using XamarinMVVM.ViewModels.Base;

namespace XamarinMVVM.ViewModels
{
    public class SplashPageViewModel : BaseViewModel
    {
        public override Task InitializeAsync(object[] args)
        {
            Navigation.InitMD();
            return Task.CompletedTask;
        }
    }
}
