using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TF2FPR.view.CategoriasView.Muebles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewItem1 : ContentPage
    {
        public ViewItem1()
        {
            InitializeComponent();
        }

        async void btnCarro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarritoCompras());
        }
    }
}