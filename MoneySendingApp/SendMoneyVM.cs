using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;

namespace MoneySendingApp
{
    public class SendMoneyVM
    {
        private static SendMoneyVM inst;
        public static SendMoneyVM Instance
        {
            get
            {
                if(inst == null)
                    inst = new SendMoneyVM();
                
                return inst;
            }
        }

        private SendMoneyVM()
        {
        }

        public string SourceCurrency
        {
            get;
            set;
        }

        public string DestinationCurrency
        {
            get;
            set;
        }

        public float Amount = 0;

        public float DestinationAmount
        {
            get
            {
                float amt = 0;

                if (SourceCurrency == "EUR" && DestinationCurrency == "USD")
                    amt = Amount * 1.2f;

                if (SourceCurrency == "USD" && DestinationCurrency == "EUR")
                    amt = Amount * 0.8f;

                if (SourceCurrency == "EUR" && DestinationCurrency == "GBP")
                    amt = Amount * 0.8f;

                if (SourceCurrency == "GBP" && DestinationCurrency == "EUR")
                    amt = Amount * 1.2f;

                if (SourceCurrency == "GBP" && DestinationCurrency == "USD")
                    amt = Amount * 1.4f;

                if (SourceCurrency == "USD" && DestinationCurrency == "GBP")
                    amt = Amount * 0.6f;

                return amt;
            }
        }

        public ICommand SendEur = new Command((x) => {
            inst.SourceCurrency = "EUR";
        });

        public ICommand SendGbp = new Command((x) => {
            inst.SourceCurrency = "GBP";
        });

        public ICommand SendUsd = new Command((x) => {
            inst.SourceCurrency = "USD";
        });

        public ICommand ToEur = new Command((x) => {
            inst.DestinationCurrency = "EUR";
        });

        public ICommand ToGbp = new Command((x) => {
            inst.DestinationCurrency = "GBP";
        });

        public ICommand ToUsd = new Command((x) => {
            inst.DestinationCurrency = "USD";
        });

        public ICommand CheckSum = new Command(() => {
            Console.WriteLine("sent");
        });
    }
}

