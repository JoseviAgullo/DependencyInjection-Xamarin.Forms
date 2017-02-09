﻿using DependencyInjection.ViewModels;
using Xamarin.Forms;

namespace DependencyInjection.Views
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel vm;

        public MainPage()
        {
            vm = new MainViewModel();
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
