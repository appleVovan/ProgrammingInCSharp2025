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

        private RelayCommand _signInCommand;
        private RelayCommand _signUpCommand;
        private RelayCommand _cancellCommand;

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

        public RelayCommand SignInCommand
        {
            get
            {
                return _signInCommand ??= new RelayCommand(SignIn, CanExecute);
            }
        }

        public RelayCommand SignUpCommand
        {
            get
            {
                return _signUpCommand ??= new RelayCommand(SignUp, CanExecute);
            }
        }

        public RelayCommand CancelCommand
        {
            get
            {
                return _cancellCommand ??= new RelayCommand(() => Environment.Exit(0));
            }
        }

        private void SignIn()
        {
            MessageBox.Show($"Login successful for user {Login}");
        }

        private void SignUp()
        {
            MessageBox.Show($"User with name {Login} was created!");
        }

        private bool CanExecute()
        {
            return !String.IsNullOrWhiteSpace(Login) && !String.IsNullOrWhiteSpace(Password);
        }

        private void UpdateCanExecute()
        {
            _signInCommand.NotifyCanExecuteChanged();
            _signUpCommand.NotifyCanExecuteChanged();
        }
    }
}
