using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinMVVM.ViewModels.Base;

namespace XamarinMVVM.Services
{
    public class NavigationService
    {
        static Lazy<NavigationService> LazyNavi = new Lazy<NavigationService>(() => new NavigationService());
        public static NavigationService Current => LazyNavi.Value;

        INavigation Navigation => ((NavigationPage)App.Current.MainPage).Navigation;

        readonly Dictionary<Type, Type> mapeamento;

        NavigationService() =>
            mapeamento = new Dictionary<Type, Type>();

        public void CriarMapeamento(Type page, Type vm)
        {
            mapeamento.Add(vm, page);
        }

        public async Task PushAsync<TViewModel>(params object[] args) where TViewModel : BaseViewModel
        {
            var pagina = LocalizaPagina<TViewModel>();

            await Navigation.PushAsync(pagina);
            await (pagina.BindingContext as BaseViewModel).InitializeAsync(args);
        }

        public async Task PopAsync(params object[] args)
        {
            await Application.Current.MainPage.Navigation.PopAsync();

            var page = Application.Current.MainPage.Navigation.NavigationStack.Last();
            
            await (page.BindingContext as BaseViewModel).ReturnedAsync(args);
            
        }

        internal async void InitNavigation<TViewModel>(object[] args) where TViewModel : BaseViewModel
        {
            var pagina = LocalizaPagina<TViewModel>();

            if (App.Current.MainPage is null)
            {
                App.Current.MainPage = new NavigationPage(pagina);

                await (pagina.BindingContext as BaseViewModel).InitializeAsync(args);
            }
        }

        Page LocalizaPagina<TViewModel>() where TViewModel : BaseViewModel
        {
            var viewModelType = typeof(TViewModel);

            var viewType = VerificarPage(viewModelType);
            Page page;

            if (viewType is null)
                return null;

            page = Activator.CreateInstance(viewType) as Page;


            var viewModel = Activator.CreateInstance(viewModelType);

            if (page != null)
                page.BindingContext = viewModel;

            return page;
        }

        Type VerificarPage(Type vm)
        {
            if (!mapeamento.ContainsKey(vm))
                return null;

            return mapeamento[vm];
        }
    }
}
