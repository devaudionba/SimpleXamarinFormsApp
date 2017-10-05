using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleXamarinFormsApp.ViewModel
{
    class CurrentLocationViewModel
    {
        private string name = "Sociale Verzekerings Bank";
        private DateTime startTime = DateTime.Now.AddMinutes(-124);
        private string gpsLocation = "N34..3424. 234 O23.5.3";

        CurrentLocationViewModel()
        {
            var task = App.Database.GetItemsAsync();
            task.Wait();

            var items = task.Result;
            foreach (var item in items)
            {
                name = item.LoggedLocation.Name;
                startTime = item.StartDate;
                gpsLocation = item.LoggedLocation.ID.ToString();
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
            }
        }

        public TimeSpan ElapsedTime
        {
            get
            {
                return DateTime.Now.Subtract(startTime);
            }
        }

        public string GpsLocation
        {
            get
            {
                return gpsLocation;
            }
            set
            {
                gpsLocation = value;
            }
        }
    }
}
