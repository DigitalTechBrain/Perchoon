using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Perchoon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private void Login_Button(object sender,EventArgs e)
        {
            //DisplayAlert("Login", "Login Sucessfull", "Ok");

            //Navigation.PushAsync(new MainPage());

            Navigation.PushModalAsync(new MainPage());
        }


        //Preventing Hardware Button From Going Back
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}