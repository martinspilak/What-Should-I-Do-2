using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using What_Should_I_Do.Models;

namespace What_Should_I_Do.Database
{
    public class ReminderDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public ReminderDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Reminder>().Wait();
        }

        public Task<List<Reminder>> GetNotesAsync()
        {
            return _database.Table<Reminder>().ToListAsync();
        }

        public Task<Reminder> GetNoteAsync(int id)
        {
            return _database.Table<Reminder>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(Reminder reminder)
        {
            if (reminder.ID != 0)
            {
                return _database.UpdateAsync(reminder);
            }
            else
            {
                return _database.InsertAsync(reminder);
            }
        }

        public Task<int> DeleteNoteAsync(Reminder reminder)
        {
            return _database.DeleteAsync(reminder);
        }
    }
}
