using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace WpfPass.Models { 
    public class AuthModel: BindableBase {

        private string _password;
        public string Password {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private string _newpassword;
        public string NewPassword {
            get => _newpassword;
            set => SetProperty(ref _newpassword, value);
        }

        private Nullable<bool> _answer;
        public Nullable<bool> Answer {
            get => _answer;
            set => SetProperty(ref _answer, value);
        }
    }
}
