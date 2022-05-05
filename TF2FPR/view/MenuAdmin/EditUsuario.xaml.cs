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
    public partial class EditUsuario : ContentPage
    {
        public EditUsuario()
        {
            InitializeComponent();
        }
        model.UserModel _userModel;
        public EditUsuario(model.UserModel userModel)
        {
            InitializeComponent();
            Title = "Editar Usuarios";
            _userModel = userModel;
            nombreApellidos.Text = userModel.NombreApellido;
            usuario.Text = userModel.Usuario;
            contraseña.Text = userModel.Contraseña;
            nombreApellidos.Focus();
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

        async void btnGuardar_Clicked(object sender, EventArgs e)
        {
             if (_userModel != null)
            {
                await DisplayAlert("Aviso", "Se actualizaron los datos", "Aceptar");
                ActualizarUsuario();
            }

            else
                await DisplayAlert("Aviso!", "No no hubo cambios", "Aceptar");
                     
        }

        
    }
}