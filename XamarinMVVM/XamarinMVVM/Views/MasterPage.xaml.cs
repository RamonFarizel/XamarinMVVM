using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinMVVM.Views
{
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        public void PageList_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {

            PageList.SelectedItem = null;
        }
    }
}
