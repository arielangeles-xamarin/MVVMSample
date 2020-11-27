using MVVMProjectSample.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Net.Mail;
using MVVMProjectSample.Views;

namespace MVVMProjectSample.ViewModels
{
    public class LoginRegisterViewModel
    {
        public User User { get; set; } = new User();
        public string ConfirmPassword { get; set; }

        public ICommand RegisterCommand { get; set; }
        public ICommand LoginCommand { get; set; }

        private const int MinPasswordLength = 8;

        public LoginRegisterViewModel()
        {
            

            RegisterCommand = new Command(async () =>
            {
                var mail = new MailAddress(User.Email);

                if (string.IsNullOrEmpty(User.Name) 
                    || string.IsNullOrEmpty(User.Username)
                    || string.IsNullOrEmpty(User.Password))
                {
                    await Application.Current.MainPage.DisplayAlert("Invalid Input",
                            $"Required field cannot be empty", "Ok");
                }
                if (!mail.Address.Equals(User.Email) && string.IsNullOrEmpty(User.Email))
                {
                    await Application.Current.MainPage.DisplayAlert("Invalid Email",
                        "Email cannot be empty and/or must be a valid one", "Ok");
                }
                else if (User.Password.Length < MinPasswordLength || string.IsNullOrEmpty(User.Password))
                {
                    await Application.Current.MainPage.DisplayAlert("Invalid Password",
                     $"Passwords must have at least {MinPasswordLength} characters", "Ok");

                }
                else if (!User.Password.Equals(ConfirmPassword))
                {
                    await Application.Current.MainPage.DisplayAlert("Invalid Password",
                        "Passwords are not the same", "Ok");
                }
                else
                {

                    await Application.Current.MainPage.DisplayAlert("Succesfull register",
                        "You have succesfully registered", "Ok");

                    await Application.Current.MainPage.Navigation.PushAsync(new HomePage());
                }
                    
            });

            LoginCommand = new Command(async () => 
            {
                
                if (string.IsNullOrEmpty(User.Username))
                {
                    await Application.Current.MainPage.DisplayAlert("Invalid Username",
                        "Username cannot be empty", "Ok");
                    
                }
                else if (User.Password.Length < MinPasswordLength || string.IsNullOrEmpty(User.Password))
                {
                    await Application.Current.MainPage.DisplayAlert("Invalid Password",
                     $"Passwords must be have at least {MinPasswordLength} characters", "Ok");

                }
                else if (!User.Password.Equals(ConfirmPassword))
                {
                    await Application.Current.MainPage.DisplayAlert("Invalid Password",
                        "Passwords are not the same", "Ok");
                }
                else
                {                    
                    await Application.Current.MainPage.Navigation.PushAsync(new HomePage());
                    await Application.Current.MainPage.DisplayAlert("Welcome Back",
                        $"Welcome back, {User.Username}, it's been quite some time", "Ok");
                }
            });

        }

    }
}
