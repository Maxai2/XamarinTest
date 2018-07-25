using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Goods : ContentPage
	{
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();

        public Goods ()
		{
			InitializeComponent ();
            BindingContext = this;

            var pro1 = new Product()
            {
                Title = "Black",
                Price = 10,
                Description = "asdfas",
                Image = "https://www.w3schools.com/w3css/img_lights.jpg"
            };

            var pro2 = new Product()
            {
                Title = "Yellow",
                Price = 20,
                Description = "asdfasfasdfasd",
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRYXVTbxmHQuOogxDeNx7U6z7neHX4kOQPZEBLG5nzQZoMMhkFN"
            };

            var pro3 = new Product()
            {
                Title = "Red",
                Price = 30,
                Description = "ASDFASDFAS",
                Image = "https://www.gettyimages.ca/gi-resources/images/Homepage/Hero/UK/CMS_Creative_164657191_Kingfisher.jpg"
            };

            Products.Add(pro1);
            Products.Add(pro2);
            Products.Add(pro3);
            Products.Add(pro3);
            Products.Add(pro3);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var item = (sender as Frame).BindingContext as Product;
            this.Navigation.PushAsync(new ProductPage(item));
        }
    }
}