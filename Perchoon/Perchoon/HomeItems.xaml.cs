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
	public partial class HomeItems : ContentPage
	{
        public List<Data> MyItems = new List<Data>()
        {
            new Data {Name = "Detol" , Price = 20 , ID = 1},
            new Data {Name = "Soap" , Price = 50 , ID = 2},
            new Data {Name = "Zera" , Price = 40 , ID = 3},
            new Data {Name = "Shampoo" , Price = 10 , ID = 4},
            new Data {Name = "Besan" , Price = 50 , ID = 5}
        };
		public HomeItems ()
		{
			InitializeComponent ();

            ItemList.ItemsSource = MyItems;

        }

        private void ItemList_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }

    public class Data
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int ID { get; set; }

    }
}