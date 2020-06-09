using System;
using System.Collections.ObjectModel;
using System.IO;
using What_Should_I_Do.Database;
using What_Should_I_Do.Models;
using Xamarin.Forms;

namespace What_Should_I_Do
{
    public partial class App
    {
        public static ReminderDatabase Database { get; private set; }

        // store replacement
        public static ObservableCollection<Reminder> Reminders { get; private set; }

        public App()
        {
            Device.SetFlags(new string[] { "SwipeView_Experimental" });
            var localFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dbPath = Path.Combine(localFolder, "Notes.db3");
            Database = new ReminderDatabase(dbPath);

            var loadedReminders = Database.GetNotesAsync().Result;
            Reminders = new ObservableCollection<Reminder>(loadedReminders);

            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
