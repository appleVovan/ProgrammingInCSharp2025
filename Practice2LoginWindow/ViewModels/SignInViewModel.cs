﻿using CommunityToolkit.Mvvm.Input;
using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.ViewModels
{
    class SignInViewModel
    {
        private UserCandidate _user = new UserCandidate();

        public string Login 
        { 
            get { return _user.Login; }
            set 
            { 
                _user.Login = value;
                UpdateCanExecute();
            }
        }
        public string Password
        {
            get { return _user.Password; }
            set 
            { 
                _user.Password = value;
                UpdateCanExecute();
            }
        }

        public RelayCommand SignInCommand { get; }
        public RelayCommand ToSignUpCommand { get; }
        public RelayCommand CancelCommand {  get; }

        public SignInViewModel(Action toSignUp)
        {
            SignInCommand ??= new RelayCommand(SignIn, CanExecute);
            ToSignUpCommand = new RelayCommand(toSignUp);
            CancelCommand ??= new RelayCommand(() => Environment.Exit(0));
        }

        private void SignIn()
        {
            MessageBox.Show($"Login successful for user {Login}");
        }

        private bool CanExecute()
        {
            return !String.IsNullOrWhiteSpace(Login) && !String.IsNullOrWhiteSpace(Password);
        }

        private void UpdateCanExecute()
        {
            SignInCommand.NotifyCanExecuteChanged();
        }
    }
}
