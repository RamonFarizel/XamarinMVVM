using System;

using Xamarin.Forms;

namespace XamarinMVVM.Views
{
    public class MDPage : MasterDetailPage
    {
        ViewModels.Page1ViewModel vm = new ViewModels.Page1ViewModel();
        ViewModels.MasterPageViewModel vmMaster = new ViewModels.MasterPageViewModel();

        public MDPage()
        {
            Detail = new NavigationPage(new Page1(){ BindingContext = vm });
            Master = new MasterPage() { BindingContext = vmMaster };
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await vm.InitializeAsync(null);
        }
    }
}

