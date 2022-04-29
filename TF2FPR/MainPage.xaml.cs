using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TF2FPR.view;
namespace TF2FPR
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            flyout.listView.ItemSelected += OnSelectedItem;
        }
        //Objeto para el menu, donde los intems selecionados llevaran a otra pagina si esque se presiona
        private void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Item;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetPage));
                flyout.listView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
