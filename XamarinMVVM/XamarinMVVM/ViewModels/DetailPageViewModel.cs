using System;
using System.Threading.Tasks;
using XamarinMVVM.ViewModels.Base;

namespace XamarinMVVM.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        public DetailPageViewModel()
        {
        }

        public override Task InitializeAsync(object[] args)
        {
            Title = "testando Detail Page";
            return base.InitializeAsync(args);
        }
    }
}
