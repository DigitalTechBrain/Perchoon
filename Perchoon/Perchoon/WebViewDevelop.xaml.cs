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
            this.InitializeComponent();
            this.BindingContext = this;
            this.IsBusy = false;

            browser.Source = "http://futurefinger.com/";

            this.IsBusy = true;


            //Webview alternate creating way in c#

            //WebView webView = new WebView
            //{
            //    Source = new UrlWebViewSource
            //    {
            //        Url = "http://futurefinger.com/",
            //    },
            //    VerticalOptions = LayoutOptions.FillAndExpand
            //};

            //// Build the page.
            //this.Content = new StackLayout
            //{
            //    Children =
            //    {

            //        webView
            //    }
            //};


        }

        private void browser_Navigating(object sender, WebNavigatingEventArgs e)
        {
            progress.IsVisible = true;
            

        }

        private void browser_Navigated(object sender, WebNavigatedEventArgs e)
        {
            progress.IsVisible = false;
        }
    }

        
    
}