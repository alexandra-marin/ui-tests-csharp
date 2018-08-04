using Xamarin.Forms;

namespace MoneySendingApp
{
    public partial class SelectSourceCurrency : ContentPage
    {
        SendMoneyVM vm;

        public SelectSourceCurrency()
        {
            InitializeComponent();

            var dest = new SelectDestinationCurrency();
            NavigationPage.SetHasNavigationBar(this, false);

            vm = SendMoneyVM.Instance;

            eur.GestureRecognizers.Add(new TapGestureRecognizer((sender, e) => {
                vm.SendEur.Execute(null);
                Navigation.PushAsync(dest);
            }));

            gbp.GestureRecognizers.Add(new TapGestureRecognizer((sender, e) => {
                vm.SendGbp.Execute(null);
                Navigation.PushAsync(dest);
            }));

            usd.GestureRecognizers.Add(new TapGestureRecognizer((sender, e) => {
                vm.SendUsd.Execute(null);
                Navigation.PushAsync(dest);
            }));
        }
    }
}

