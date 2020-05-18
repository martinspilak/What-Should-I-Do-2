using Xamarin.Forms;

namespace What_Should_I_Do
{
    public partial class AddItemPage
    {
        public AddItemPage() 
        { 
            InitializeComponent();
        }

        private void OnPriorityChanged(object sender, ValueChangedEventArgs e)
        {
            PriorityValueLabel.Text = ((int) e.NewValue).ToString();
        }
    }
}