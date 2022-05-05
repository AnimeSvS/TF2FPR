using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TF2FPR.view.CategoriasView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TF2FPR.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioT1 : ContentPage
    {
        public InicioT1()
        {
            InitializeComponent();
        }

        private void btnDetalle_Clicked(object sender, EventArgs e)
        {

        }

        async void btnMuebles_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewMuebles());
        }
    }
}