using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TF2FPR.view.MenuAdmin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioAdmin : ContentPage
    {
        public InicioAdmin()
        {
            InitializeComponent();
        }

        async void btnUser_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaUsuarios());
        }

        async void btnProductos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditProducto());
        }

        private void btnVentas_Clicked(object sender, EventArgs e)
        {

        }
    }
}