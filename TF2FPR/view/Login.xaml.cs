using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TF2FPR.model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TF2FPR.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

   
        async void btnInicio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());

        }
    }
}