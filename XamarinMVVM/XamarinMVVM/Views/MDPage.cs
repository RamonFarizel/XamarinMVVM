using System;

using Xamarin.Forms;

namespace XamarinMVVM.Views
{
    public class MDPage : MasterDetailPage
    {
        ViewModels.DetailPageViewModel vm = new ViewModels.DetailPageViewModel();
        ViewModels.MasterPageViewModel vmMaster = new ViewModels.MasterPageViewModel();

        public MDPage()
        {
            Detail = new NavigationPage(new DetailPage(){ BindingContext = vm });
            Master = new MasterPage() { BindingContext = vmMaster };
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await vm.InitializeAsync(null);
        }
    }
}

