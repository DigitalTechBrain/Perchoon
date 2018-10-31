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

            // Activity Indicator means Loading...
            this.InitializeComponent();
            this.BindingContext = this;
            this.IsBusy = true;

            NavigateToRegistration();
        }



        private void Login_Button(object sender,EventArgs e)
        {
            // DisplayAlert("Login", "Login Sucessfull", "Ok");

            //Navigation.PushAsync(new MainPage());

            // Consuming Web Service
           // LoginAuthentication.Connect_WS connect = new LoginAuthentication.Connect_WS();
           

            Navigation.PushModalAsync(new MainPage(UserName.Text));
        }


        //Preventing Hardware Button From Going Back
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        void NavigateToRegistration()
        {
            Lblclick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
               {
                   Navigation.PushModalAsync(new Registration());
               })
               
            });
          
            this.IsBusy = false;
        }


    }
}