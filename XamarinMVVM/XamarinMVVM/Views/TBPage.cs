using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using TabbedPage = Xamarin.Forms.TabbedPage;

namespace XamarinMVVM.Views
{
    public class TBPage : TabbedPage
    {
        

        public TBPage()
        {
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

            ViewModels.TabbedPage1ViewModel vm1 = new ViewModels.TabbedPage1ViewModel();
            ViewModels.TabbedPage2ViewModel vm2 = new ViewModels.TabbedPage2ViewModel();
           

            Children.Add(new TabbedPage1 { BindingContext = vm1 });
            Children.Add(new TabbedPage2 { BindingContext = vm2 });
        }
    }
}
