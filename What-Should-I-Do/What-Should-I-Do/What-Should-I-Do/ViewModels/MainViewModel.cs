using System.Collections.ObjectModel;
using System.Windows.Input;
using What_Should_I_Do.Models;
using Xamarin.Forms;

namespace What_Should_I_Do.ViewModels
{
    public sealed class MainViewModel
    {
        public ObservableCollection<Reminder> Reminders => App.Reminders;

        public ICommand AddCommand { get; }

        public MainViewModel()
        {
            AddCommand = new Command(HandleAdd);
        }

        private async void HandleAdd()
        {
            var nav = (NavigationPage) Application.Current.MainPage;
            await nav.PushAsync(new AddItemPage());
        }
    }
}
