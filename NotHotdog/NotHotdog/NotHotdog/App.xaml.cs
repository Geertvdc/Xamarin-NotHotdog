﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using NotHotdog.Constants;
using Xamarin.Forms;

namespace NotHotdog
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NotHotdog.MainPage();
        }

        protected override void OnStart()
        {
            MobileCenter.Start("android=" + ApiKeys.MOBILECENTER_DROID_KEY + ";" +
                               "ios=" + ApiKeys.MOBILECENTER_IOS_KEY,
				   typeof(Analytics), typeof(Crashes));
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
