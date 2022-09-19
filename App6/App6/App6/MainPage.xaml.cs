using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Stripe;
using Newtonsoft.Json;

namespace App6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string mycustomer;
        string getchargedID;
        string refundID;

        [Obsolete]
        public void NewEventHandler(object sender, EventArgs e)
        {
            StripeConfiguration.SetApiKey("sk_test_51LhokfSArx4pZrRYoDrbe3MtbwlppIAf2vbWPBMi2nt4CwGSEGkG7DILfjI80qfkt0d0PJpZHcG5OLE9u6yNNM6u00BOW3bzqt");
            Stripe.CreditCardOptions stripcard = new Stripe.CreditCardOptions();
            stripcard.Number = "5000458002008046";
            stripcard.ExpYear = 2024;
            stripcard.ExpMonth = 12;
            stripcard.Cvc = 245;
            Stripe.TokenCreateOptions token = new Stripe.TokenCreateOptions( );
            token.Card = stripcard;
            Stripe.TokenService serviceToken = new Stripe.TokenService();
            Stripe.Token newToken = serviceToken.Create(token);
            var options = new SourceCreateOptions
            {
                Type = SourceType.Card,
                Currency = "usd",
                Token = newToken.Id
            };
            var service = new SourceService();
            Source source = service.Create(options);
            Stripe.CustomerCreateOptions myCustomer = new Stripe.CustomerCreateOptions()
            {
                Name = "Sara",
                Email = "saradc@gmail.com",
                Description = "Customer for jennyclub@example.com",
            };
            var chargeoptions = new Stripe.ChargeCreateOptions()
            {
                Amount = 123,
            Currency = "USD",
            ReceiptEmail = "sanjuchithu@gmail.com",
                Customer = stripeCustomer.Id,
            Source = source.Id,
        };
        var service1 = new Stripe.ChargeService();
        Stripe.Charge charge = service1.Create(chargeoptions);
        getchargedID=Charge.Id;
        }
    public void GetCustomerInformationID(Object sender,EventArgs e)
    {
        var service = new CustomerService();
        var customer = service.Get(mycustomer);
        var serializedCustomer = JsonConvert.SerializeObject(customer);
    }
    public void GetAllCustomerInformation(Object sender,EventArgs e)
    {
        var service = new CustomerService();
            var options = new CustomerListOptions();
    }
    }
}
