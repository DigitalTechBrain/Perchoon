﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Perchoon
{
    public partial class MainPage : ContentPage
    {
        public MainPage( string username )
        {
            InitializeComponent();

            DispUserName.Text = "Hello  " + username;

            NavigateToUrl();
        }

        protected override bool OnBackButtonPressed()
        {
            return false;
        }

        void NavigateToUrl()
        {
            CompanyUrl.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Navigation.PushModalAsync(new WebViewDevelop());

                })

            });
        }

        private void HomeItems_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new HomeItems());
        }

        private void HarwareItems_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new HardwareItems());
        }

        private void ElectronicItems_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Electronics());
        }

        private void VegetableItems_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Vegetables());
        }

        private void FoodItems_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new JunkFoods());
        }

        private void DrinkItems_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new DairyProducts());
        }

        private void WorkerServices_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new WorkerServices());
        }

        private void HelpSupport_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Support());
        }
    }
}
