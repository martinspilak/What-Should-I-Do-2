using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace What_Should_I_Do
{
    class ReminderListViewModel
    {
        public ICommand AddReminderCommand => new Command(AddReminder);
        public ObservableCollection<string> Reminders => ReminderList.Reminders;
        public string ReminderName { get; set; }
        public string Priority { get; set; }
        public string CompleteTime { get; set; }
        public ReminderListViewModel()
        {
        }
        public void AddReminder()
        {
            Reminders.Add(ReminderName);
            Reminders.Add(Priority);
            Reminders.Add(CompleteTime);
        }
    }
}
