﻿using System;

using Xamarin.Forms;

namespace MoneySendingApp
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new SelectSourceCurrency()) { BarBackgroundColor = Color.FromHex("2196F3"), BackgroundColor = Color.FromHex("2196F3")};
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

