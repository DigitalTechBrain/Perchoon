using System;
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

    }
}
