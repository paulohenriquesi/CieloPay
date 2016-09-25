﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CieloPay.ClientApp.App.Pages;
using Xamarin.Forms;

namespace PedidoFacin.Drugstore.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MasterPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
