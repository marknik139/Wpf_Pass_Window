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


        private string _login;
        public string Login
        {
            get => _login;
            set => SetProperty(ref _login, value);
        }


        private string _fio;
        public string Fio
        {
            get => _fio;
            set => SetProperty(ref _fio, value);
        }


        private int _age;
        public int Age
        {
            get => _age;
            set => SetProperty(ref _age, value);
        }


        private bool _isChecked;
        public bool IsChecked
        {
            get => _isChecked;
            set => SetProperty(ref _isChecked, value);
        }

    }
}
