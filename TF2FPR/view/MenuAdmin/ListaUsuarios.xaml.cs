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

        private  void editU_Invoked(object sender, EventArgs e)
        {
           
        }

        private void deleteU_Invoked(object sender, EventArgs e)
        {

        }
    }
}