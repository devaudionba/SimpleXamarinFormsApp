using SimpleXamarinFormsApp.Interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleXamarinFormsApp.Model
{
    public class TimesheetDatabase
    {
        readonly SQLiteAsyncConnection database;

        public TimesheetDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<LoggedTimesheetItem>().Wait();
        }

        public Task<List<LoggedTimesheetItem>> GetItemsAsync()
        {
            return database.Table<LoggedTimesheetItem>().ToListAsync();
        }

        public Task<List<LoggedTimesheetItem>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<LoggedTimesheetItem>("SELECT * FROM [TimesheetItem] WHERE [Done] = 0");
        }

        public Task<LoggedTimesheetItem> GetItemAsync(int id)
        {
            return database.Table<LoggedTimesheetItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(LoggedTimesheetItem item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(LoggedTimesheetItem item)
        {
            return database.DeleteAsync(item);
        }
    }
}
