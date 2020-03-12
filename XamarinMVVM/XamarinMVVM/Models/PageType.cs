using System;
namespace XamarinMVVM.Models
{
    public class PageType
    {
        public string Name { get; set; }
        public ViewModelType TypePage { get; set; }
    }

    public enum ViewModelType
    {
        Pagina1ViewModel,
        Pagina2ViewModel,
        TabbedPageViewModel
    }
}

