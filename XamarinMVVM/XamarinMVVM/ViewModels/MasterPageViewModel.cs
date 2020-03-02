using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMVVM.Models;
using XamarinMVVM.ViewModels.Base;

namespace XamarinMVVM.ViewModels
{
    public class MasterPageViewModel : BaseViewModel
    {
        public ObservableCollection<PageType> Pages { get; }
        public ICommand NavegateCommand { get; }

        public MasterPageViewModel()
        {
            NavegateCommand = new Command<object>(async (page) => await ExecuteNavegateCommand(page));
            Pages = new ObservableCollection<PageType>();
            PopulateMaster();
        }

        private async Task ExecuteNavegateCommand(object page)
        {
            if(page is PageType)

            switch (((PageType)page).TypePage)
            {
                case ViewModelType.Pagina1ViewModel:
                    await Navigation.PushAsync<Page1ViewModel>(true);
                    break;

                case ViewModelType.Pagina2ViewModel:
                    await Navigation.PushAsync<Page2ViewModel>(true);
                    break;
                }
            
        }

        private void PopulateMaster()
        {
            try
            {
                var pages = new[]
                {
                    new PageType { Name = "Pagina 1", TypePage = ViewModelType.Pagina1ViewModel},
                    new PageType { Name = "Pagina 2", TypePage = ViewModelType.Pagina2ViewModel},
                    new PageType { Name = "Pagina 3", TypePage = ViewModelType.Pagina3ViewModel},
                };

                foreach (var item in pages)
                    Pages.Add(item);
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
        }
    }
}
