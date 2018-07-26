using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductPage : ContentPage
	{
        public Product pro { get; set; }

        public ProductPage (Product product)
		{
            pro = product;
			InitializeComponent();

            BindingContext = this;
		}

        private void BuyB_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "bought", pro);
            this.Navigation.PopModalAsync();
        }
    }
}