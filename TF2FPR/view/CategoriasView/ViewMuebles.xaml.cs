using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TF2FPR.view.CategoriasView.Muebles;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TF2FPR.view.CategoriasView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewMuebles : ContentPage
    {
        public ViewMuebles()
        {
            InitializeComponent();
        }

        async void btnDetalleItem1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewItem1());

        }
    }
}