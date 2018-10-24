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
        }

        protected override bool OnBackButtonPressed()
        {
            return false;
        }

    }
}
