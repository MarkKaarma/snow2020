﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace snow2020
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Snow2_0();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
