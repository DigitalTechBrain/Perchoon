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
	public partial class WebViewDevelop : ContentPage
	{
		public WebViewDevelop ()
		{
			InitializeComponent ();

            

            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "http://futurefinger.com/",
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    
                    webView
                }
            };
        }
    }

        
    
}