using SimpleXamarinFormsApp.Interfaces;
using SimpleXamarinFormsApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SimpleXamarinFormsApp
{
    public partial class App : Application
    {
        static TimesheetDatabase database;

        public App()
        {
            InitializeComponent();

            MainPage = new SimpleXamarinFormsApp.View.CurrentLocationView();
        }

        public static TimesheetDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new TimesheetDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("TodoSQLite.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
