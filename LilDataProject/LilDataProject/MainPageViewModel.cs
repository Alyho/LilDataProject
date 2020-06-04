using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;
using LilDataProject.Models;
using Xamarin.Essentials;

namespace LilDataProject
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public Command ShowUser1Command { get; }
        public Command ShowUser2Command { get; }
        public ObservableCollection<User> NotesCollection { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        IData data = new UserData();
        
        private string username;
        private string userage;
        private string useremail;
        private string useraddress;
        private string userphonenumber;


        public MainPageViewModel()
        {

            NotesCollection = new ObservableCollection<User>();

            ShowUser1Command = new Command(() =>
                                           {
                                               var _user = data.GetUser(0);

                                               UserName = _user.Name;
                                               UserAge = _user.Age;
                                               UserEmail = _user.Email;
                                               UserAddress = _user.Address;
                                               UserPhoneNumber = _user.PhoneNumber;
                                           });

            ShowUser2Command = new Command(() =>
                                           {
                                               var _user = data.GetUser(1);
                                               UserName = _user.Name;
                                               UserAge = _user.Age;
                                               UserEmail = _user.Email;
                                               UserAddress = _user.Address;
                                               UserPhoneNumber = _user.PhoneNumber;
                                           });

        }

        
        


        public string UserName
        {
            get => username;
            set
            {
                if (username != value)
                {
                    username = value;
                    var args = new PropertyChangedEventArgs(nameof(UserName));

                    PropertyChanged?.Invoke(this, args);
                    ShowUser1Command.ChangeCanExecute();
                }
            }
        }

        public string UserAge
        {
            get => userage;
            set
            {
                if (userage != value)
                {
                    userage = value;
                    var args = new PropertyChangedEventArgs(nameof(UserAge));

                    PropertyChanged?.Invoke(this, args);
                    ShowUser1Command.ChangeCanExecute();
                }
            }
        }

        public string UserEmail
        {
            get => useremail;
            set
            {
                if (useremail!= value)
                {
                    useremail= value;
                    var args = new PropertyChangedEventArgs(nameof(UserEmail));

                    PropertyChanged?.Invoke(this, args);
                    ShowUser1Command.ChangeCanExecute();
                }
            }
        }

        public string UserAddress
        {
            get => useraddress;
            set
            {
                if (useraddress!= value)
                {
                    useraddress= value;
                    var args = new PropertyChangedEventArgs(nameof(UserAddress));

                    PropertyChanged?.Invoke(this, args);
                    ShowUser1Command.ChangeCanExecute();
                }
            }
        }

        public string UserPhoneNumber
        {
            get => userphonenumber;
            set
            {
                if (userphonenumber!= value)
                {
                    userphonenumber = value;
                    var args = new PropertyChangedEventArgs(nameof(UserPhoneNumber));

                    PropertyChanged?.Invoke(this, args);
                    ShowUser1Command.ChangeCanExecute();
                }
            }
        }

        

    }

  
}
   
