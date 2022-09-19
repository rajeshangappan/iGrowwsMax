using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Stripe;
using Newtonsoft.Json;



namespace App7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        public void PayViaStripe()
        {
            StripeConfiguration.ApiKey = "sk_test_51LhokfSArx4pZrRYoDrbe3MtbwlppIAf2vbWPBMi2nt4CwGSEGkG7DILfjI80qfkt0d0PJpZHcG5OLE9u6yNNM6u00BOW3bzqt"; 
            string cardno = cardNo.Text;
            string expMonth = expireMonth.Text;
            string expYear = expireYear.Text;
            string CardCvv = cvv.Text;

            CreditCardOptions stripeOption = new CreditCardOptions();
            stripeOption.Number = cardno;
            stripeOption.ExpYear = Convert.ToInt64(expireYear);
            stripeOption.ExpMonth = Convert.ToInt64(expireMonth);
            stripeOption.CvC = CardCvv;

            TokenCreateOptions stripeCard = new TokenCreateOptions();
            stripeCard.Card = stripeOption;

            TokenService service = new TokenService();
            Token newToken = service.Create(stripeCard);

            var option = new SourceCreateOptions
            {
                Type = SourceType.Card,
                Currency = "inr",
                Token = newToken.Id,
            };
            var sourceService = new SourceService();
            Source source = sourceService.Create(option);

            CustomerCreateOptions customer = new CustomerCreateOptions
            {
                Name = "Saradeveloper",
                Email = "sujithravivekanandh@gmail.com",
                Description = "Pay 10 Rs",
                Address = new AddressOptions { City = "Kolkata", Country = "India", Line1 = "Address1", Line2 = "Adress2", PostalCode = "700030", State = "WB" }

            };
            var customerService = new CustomerService();
            var cust = customerService.Create(customer);
            var chargeoption = new ChargeCreateOptions
            {
                Amount = 1000,
                Currency = "INR",
                ReceiptEmail = "",
                Customer = cust.Id,
                Source = source.Id,
            };
            var chargeService = new ChargeService();
            Charge charge = chargeService.Create(chargeoption);
            if(charge.Status=="succeeded")
            {
                //success
            }
            else
            {
                //failed
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PayViaStripe();
        }
    }
           
            }




