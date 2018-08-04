using Xamarin.Forms;

namespace MoneySendingApp
{
    public partial class Confirmation : ContentPage
    {
        static SendMoneyVM vm;

        public Confirmation()
        {
            InitializeComponent();
         
            NavigationPage.SetHasNavigationBar(this, false);

            vm = SendMoneyVM.Instance;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            final.Text = string.Format("You've sent {0} {1} as {2} {3}.", vm.Amount, vm.SourceCurrency, vm.DestinationAmount, vm.DestinationCurrency);
        }
    }
}

