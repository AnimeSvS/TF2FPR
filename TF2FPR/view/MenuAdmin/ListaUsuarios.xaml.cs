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
    public partial class ListaUsuarios : ContentPage
    {
        public ListaUsuarios()
        {
            InitializeComponent();
        }

       async void BuscarUsuarios_TextChanged(object sender, TextChangedEventArgs e)
        {
            vistaUsuarios.ItemsSource = await App.Database.Search(e.NewTextValue);
        }

        private async  void editU_Invoked(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var uE = item.CommandParameter as UserModel;
            await Navigation.PushAsync(new EditUsuario(uE));
        }

        private async void deleteU_Invoked(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var uE = item.CommandParameter as UserModel;
            var result = await DisplayAlert("Aviso!☣", $"Desea borrar {uE.NombreApellido}", "Si", "No");
            if (result)
            {
                await App.Database.DeleteUsuario(uE);
                vistaUsuarios.ItemsSource = await App.Database.ReadUsuario();
            }
        }

        async void AddUser_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }
    }
}


