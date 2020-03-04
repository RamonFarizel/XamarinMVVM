using System;
using System.Threading.Tasks;
using XamarinMVVM.ViewModels.Base;

namespace XamarinMVVM.ViewModels
{
    public class PageTesteViewModel: BaseViewModel
    {
        public PageTesteViewModel()
        {
        }

        public override Task InitializeAsync(object[] args)
        {
            Title = "Navegação Page teste";
            return base.InitializeAsync(args);
        }
    }
}
