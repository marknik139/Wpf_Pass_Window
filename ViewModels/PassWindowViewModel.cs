using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using System.Windows;
using System.Windows.Input;
using WpfPass.Models;
using System.Windows.Controls;

namespace WpfPass.ViewModels { 

    class PassWindowViewModel: BindableBase{

        private AuthModel _authInfo;
        public AuthModel AuthInfo {
            get => _authInfo;
            set => SetProperty(ref _authInfo, value);
        }

        public ICommand CheckPass { get; set; }
        public PassWindowViewModel() {

            CheckPass = new DelegateCommand(Refresh);
            AuthInfo = new AuthModel();
        }

        private void Refresh()
        {
         
            if ((AuthInfo.Password == AuthInfo.NewPassword) && string.IsNullOrEmpty(AuthInfo.Password)==false) {
                AuthInfo.Answer = true;
            }

            else {
                AuthInfo.Password = AuthInfo.NewPassword = string.Empty;
                AuthInfo.Answer = false;
            }
        }
    }
}
