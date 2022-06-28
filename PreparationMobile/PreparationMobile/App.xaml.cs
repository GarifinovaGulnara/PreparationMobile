using PreparationMobile.DB;
using PreparationMobile.Models;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PreparationMobile
{
    public partial class App : Application
    {
        public const string DB_NAME = "Preparations.db";
        public static CRUDOperations db;
        public static Client client;
        public static CRUDOperations Db
        {
            get
            {
                if (db == null)
                {
                    db = new CRUDOperations(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DB_NAME));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
