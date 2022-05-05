﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TF2FPR.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            Title = "Productos 🏠";
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        //DENTRO DEL CONTROL DE BUSQUEDA , LLAMAMOS A LA VARIABLE QUE SE PUSO AL COLLECTION VIEW
        // ESA VARAIBLE BUSCARA CON EL METODO SEARCHPRODUCTO Y AHI LO BUSCARA POR SU NOMBRE
        async void BuscarProductos_TextChanged(object sender, TextChangedEventArgs e)
        {
            vistaProductos.ItemsSource = await App.Database.SearchProducto(e.NewTextValue);
        }

        
        private void editP_Invoked(object sender, EventArgs e)
        {

        }

        private void deletP_Invoked(object sender, EventArgs e)
        {

        }

        private void infoP_Invoked(object sender, EventArgs e)
        {

        }
    }
}