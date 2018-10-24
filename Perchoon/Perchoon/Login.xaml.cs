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

            await Navigation.PushAsync(new MainPage());
        }

    }
}