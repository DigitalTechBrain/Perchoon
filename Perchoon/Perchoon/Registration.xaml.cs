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
	public partial class Registration : ContentPage
	{
		public Registration ()
		{
			InitializeComponent ();
		}

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "Registered Sucessfully...", "Ok");
        }
    }
}