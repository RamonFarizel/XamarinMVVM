using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;
using XamarinMVVM.Services;

namespace XamarinMVVM.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private string _titlePage;
        public string TitlePage
        {
            get { return _titlePage; }
            set
            {
                SetProperty(ref _titlePage, value);
            }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                SetProperty(ref _isBusy, value);
            }
        }

        public virtual Task LoadAsync(object[] args) => Task.FromResult(true);
        public virtual Task LoadAsync() => Task.FromResult(true);
        protected NavigationService Navigation => NavigationService.Current;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs((propertyName)));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }
            storage = value;
            OnPropertyChanged(propertyName);

            return true;
        }

    }
}
