using System;
using Xamarin.Forms;

namespace MoneySendingApp
{
    public partial class EnterAmount : ContentPage
    {
        SendMoneyVM vm;

        public EnterAmount()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            var dest = new Confirmation();

            vm = SendMoneyVM.Instance; 

            amount.TextChanged += (sender, e) => {
                float.TryParse(amount.Text, out vm.Amount);

                if(vm.Amount > 0)
                    confirmLabel.Text = string.Format("Do you want to send {0} {1} as {2}?", vm.Amount,vm.SourceCurrency, vm.DestinationCurrency);
                else
                    confirmLabel.Text = "";
            };

            confirm.Clicked += (sender, e) => {
                if(vm.Amount > 0)
                    Navigation.PushModalAsync(dest);
                else
                    DisplayAlert("Error", "Please enter a valid amount", "OK");
            };
        }
    }
}

