using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TF2FPR.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        
        }
        model.UserModel _userModel;
        public Registro(model.UserModel userModel)
        {
            InitializeComponent();
            Title = "Editar Usuarios";
            _userModel = userModel;
            nombreApellidos.Text = userModel.NombreApellido;
            usuario.Text = userModel.Usuario;
            contraseña.Text = userModel.Contraseña;
            nombreApellidos.Focus();
        }
        //AGREGA USUARIOS CON LOS DATOS QUE OBTIENE DE CADA ENTRY
        async void AgregarUsuario()
        {
            await App.Database.CreateUsuario(new model.UserModel
            {
                NombreApellido = nombreApellidos.Text,
                Usuario = usuario.Text,
                Contraseña = contraseña.Text


            });
            await Navigation.PopAsync();
        }
        //ACTUALIZA LOS USUARIOS CON LOS DATOS QUE VUELVE A RECIBIR
        async void ActualizarUsuario()
        {
            _userModel.NombreApellido = nombreApellidos.Text;
            _userModel.Usuario = usuario.Text;
            _userModel.Contraseña = contraseña.Text;
            await App.Database.UpdateUsuario(_userModel);
            await Navigation.PopAsync();
        }

       

        private void calendario_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

      //EL BOTON REGISTRO TIENE UNA CONDICIONAL LA CUAL SE ASEGURA, QUE TODAS LOS ENTRYS CONTENGAN DATOS 
      //SI LOS DATOS SON VACIOS MOSTRARA UNA ALERTA DE ERROR
      //DE LO CONTRARIO ACTUALIZA O AGREGA EL USUARIO
        async void btnRegistro_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreApellidos.Text) || string.IsNullOrWhiteSpace(usuario.Text) || string.IsNullOrWhiteSpace(contraseña.Text))
            {
                await DisplayAlert("Error", "No puede estar vacio", "Aceptar");
            }
            else if (_userModel != null)
            {
                ActualizarUsuario();
            }

            else
                AgregarUsuario();
        }

        async void btnIniciarS_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
    }
}