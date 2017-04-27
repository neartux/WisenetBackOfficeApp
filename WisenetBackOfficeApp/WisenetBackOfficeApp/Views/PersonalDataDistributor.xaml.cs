﻿using WisenetBackOfficeApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WisenetBackOfficeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalDataDistributor : ContentPage
    {
        public PersonalDataDistributor()
        {
            InitializeComponent();

            BindingContext = new PersonalDataDistributorViewModel();
        }
    }
}
