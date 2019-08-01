using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMVVM.ViewModels.Base;

namespace XamarinMVVM.ViewModels
{
    public class Page1ViewModel : BaseViewModel
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private bool _podeNavegar;
        public bool PodeNavegar
        {
            get { return _podeNavegar; }
            set
            {
               SetProperty(ref( _podeNavegar) ,value);
                ((Command)CmdVoltar).ChangeCanExecute();
            }
        }

        public ICommand CmdVoltar { get; set; }

        public Page1ViewModel(Dictionary<string, string> Param)
        {
            Nome = Param["Nome"];
            CmdVoltar = new Command(async () => await ExecuteNavegar(), CanExecute);
            //CmdVoltar.CanExecuteChanged += CmdVoltar_CanExecuteChanged;
        }

        //private void CmdVoltar_CanExecuteChanged(object sender, EventArgs e)
        //{
           
        //}

        private bool CanExecute()
        {
            return PodeNavegar;
        }

        private async Task ExecuteNavegar()
        {
            await Navigation.PopAsync();
        }
    }
}
