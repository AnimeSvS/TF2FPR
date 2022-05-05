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
    public partial class ProductoAgregar : ContentPage
    {
        public ProductoAgregar()
        {
            InitializeComponent();
        }
        model.ShopModel _shopModel;
        public ProductoAgregar(model.ShopModel shopModel)
        {
            //INICIALIZACION Y ENVIO DE DATOS DE CADA ENTRY HACIA LAS VARIABLES DE LA TABLA PRODUCTO
            InitializeComponent();
            Title = "Productos";
            _shopModel = shopModel;
            productoName.Text = shopModel.NombreP;
            precioP.Text = shopModel.PrecioP;
            cantidadP.Text = shopModel.CantidadP;
            categoriaP.Text = shopModel.Categoria;
            estadoP.Text = shopModel.EstadoP;
            descripcionP.Text = shopModel.DescripcionP;
            //imagenP.Text = shopModel.ImageP;

            productoName.Focus();
        }

        async void AgregarProducto()
        {
            await App.Database.CreateProducto(new model.ShopModel
            {
                NombreP = productoName.Text,
                PrecioP = precioP.Text,
                CantidadP = cantidadP.Text,
                Categoria = categoriaP.Text,
                EstadoP = estadoP.Text,
                DescripcionP = descripcionP.Text,
                //ImageP = imagenP.Text



            });
            await Navigation.PopAsync();
        }
        async void ActualizarProducto()
        {
            _shopModel.NombreP = productoName.Text;
            _shopModel.PrecioP = precioP.Text;
            _shopModel.CantidadP = cantidadP.Text;
            _shopModel.Categoria = categoriaP.Text;
            _shopModel.EstadoP = estadoP.Text;
            _shopModel.DescripcionP = descripcionP.Text;
            //_shopModel.ImageP = imagenP.Text;
            await App.Database.UpdateProducto(_shopModel);
            await Navigation.PopAsync();
        }
        async void btnAgregarP_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productoName.Text) || string.IsNullOrWhiteSpace(cantidadP.Text))
            {
                await DisplayAlert("Error", "No puede estar vacio", "Aceptar");
            }
            else if (_shopModel != null)
            {
                ActualizarProducto();
            }

            else
                AgregarProducto();

        }
    }
}