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
using System.Collections.ObjectModel;

namespace WpfPass.ViewModels {

    class PassWindowViewModel : BindableBase {


        private ObservableCollection<AuthModel> _people;
        public ObservableCollection<AuthModel> People
        {
            get => _people;
            set => SetProperty(ref _people, value);
        }


        private AuthModel _selectedFio;
        public AuthModel SelectedFio
        {
            get => _selectedFio;
            set => SetProperty(ref _selectedFio, value);
        }


        public PassWindowViewModel()
        {

            _people = new ObservableCollection<AuthModel> {

                new AuthModel() {
                    Login="marknik", 
                    Password="ybiy za wpf", 
                    Fio="Маркелов Никита Антонович", 
                    Age=20, 
                    IsChecked=true},


                new AuthModel() {
                    Login="mihail",
                    Password="mvvm rulit",
                    Fio="Лазаренко Михаил Олегович",
                    Age=25,
                    IsChecked=true},

                new AuthModel() {
                    Login="sasha228",
                    Password="qwert5",
                    Fio="Шляпик Александр Александрович",
                    Age=14,
                    IsChecked=false},

                new AuthModel() {
                    Login="tonya",
                    Password="parol222",
                    Fio="Алаева Антонина Александровна",
                    Age=25,
                    IsChecked=true},

            };

        }

    }
}
