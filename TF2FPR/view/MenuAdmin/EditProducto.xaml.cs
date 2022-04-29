using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TF2FPR.model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TF2FPR.view.MenuAdmin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditProducto : ContentPage
    {
        public EditProducto()
        {
            InitializeComponent();
        }

        async void BuscarProductos_TextChanged(object sender, TextChangedEventArgs e)
        {
            vistaProductos.ItemsSource = await App.Database.SearchProducto(e.NewTextValue);
        }

        private  async void editP_Invoked(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var Sp = item.CommandParameter as ShopModel;
            await Navigation.PushAsync(new ProductoAgregar(Sp));
        }

        private async void deletP_Invoked(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var sP = item.CommandParameter as ShopModel;
            var result = await DisplayAlert("Aviso!☣", $"Desea borrar {sP.NombreP}", "Si", "No");
            if (result)
            {
                await App.Database.DeleteProducto(sP);
                vistaProductos.ItemsSource = await App.Database.ReadProducto();
            }
        }

        async void AddProducto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductoAgregar());
        }
    }
 }
