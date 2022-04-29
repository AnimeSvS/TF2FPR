using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TF2FPR.view;
using System.IO;
using TF2FPR.data;

namespace TF2FPR
{
    public partial class App : Application
    {
        private static BDShop db;
        public static BDShop Database
        {
            get
            {
                if (db == null)
                {
                    db = new BDShop(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "shop.db3"));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Index());
            //MainPage =  new Index();
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
