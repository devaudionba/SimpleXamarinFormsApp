using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleXamarinFormsApp.Model
{
    public class LoggedTimesheetItem
    {
        public int ID { get; set; }

        public Location LoggedLocation { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
