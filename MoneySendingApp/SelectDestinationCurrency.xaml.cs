using Xamarin.Forms;

namespace MoneySendingApp
{
    public partial class SelectDestinationCurrency : ContentPage
    {
        static SendMoneyVM vm;

        public SelectDestinationCurrency()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            var dest = new EnterAmount();

            vm = SendMoneyVM.Instance;

            eur.GestureRecognizers.Add(new TapGestureRecognizer((sender, e) => {
                if(vm.SourceCurrency == "EUR")
                {
                    DisplayAlert("Error", "Destination currency can't be the same as source", "OK");
                    return;
                }

                vm.ToEur.Execute(null);
                Navigation.PushAsync(dest);
            }));

            gbp.GestureRecognizers.Add(new TapGestureRecognizer((sender, e) => {
                if(vm.SourceCurrency == "GBP")
                {
                    DisplayAlert("Error", "Destination currency can't be the same as source", "OK");
                    return;
                }
                vm.ToGbp.Execute(null);
                Navigation.PushAsync(dest);
            }));

            usd.GestureRecognizers.Add(new TapGestureRecognizer((sender, e) => {
                if(vm.SourceCurrency == "USD")
                {
                    DisplayAlert("Error", "Destination currency can't be the same as source", "OK");
                    return;
                }
                vm.ToUsd.Execute(null);
                Navigation.PushAsync(dest);
            }));
        }
    }
}

