﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WisenetBackOfficeApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WisenetBackOfficeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            BindingContext = new LoginViewModel();
        }
    }
}
