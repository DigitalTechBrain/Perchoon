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
	public partial class OrderSummary : ContentPage
	{
		public OrderSummary ()
		{
			InitializeComponent ();
		}
	}
}