using Xamarin.Forms;
using XamarinMVVM.Services;
using XamarinMVVM.ViewModels;
using XamarinMVVM.Views;

namespace XamarinMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationService.Current.CriarMapeamento(typeof(MainPage),typeof(MainPageViewModel));
            NavigationService.Current.CriarMapeamento(typeof(Pagina1), typeof(Pagina1ViewModel));
            NavigationService.Current.CriarMapeamento(typeof(Pagina2), typeof(Pagina2ViewModel));

            NavigationService.Current.InitNavigation<MainPageViewModel>(null);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
