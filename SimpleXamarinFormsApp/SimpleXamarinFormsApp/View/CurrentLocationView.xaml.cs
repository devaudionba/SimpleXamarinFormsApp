using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleXamarinFormsApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrentLocationView : ContentPage
    {
        public CurrentLocationView()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Database.SaveItemAsync(new Model.LoggedTimesheetItem
            {
                ID = 3,
                StartDate = DateTime.Now,
                LoggedLocation = new Model.Location
                {
                     ID = 1,
                     Name = "Test Locatie"
                }
            });
        }
    }
}