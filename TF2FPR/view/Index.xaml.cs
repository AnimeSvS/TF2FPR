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
    public partial class Index : ContentPage
    {
        public Index()
        {
            InitializeComponent();
          
        }

        async void ingresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        async void registrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }

      
    }
}


