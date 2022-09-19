using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Stripe;
using System.Threading;
using Microsoft.Identity.Client;

namespace App8
{
    public partial class MainPage : ContentPage
    {
        public Token stripeToken;
        public TokenService TokenService;
        public string TestApikey = "pk_test_51LhokfSArx4pZrRYyxQByj11ZVHWZPo2Z6ps2ox9LWM4p3g4ANXNFnxmgCpeq1hImuawrCsncRoktryGtBAoHUPT00CH3RO3r3";


        public MainPage()
        {
            InitializeComponent();
        }

        [Obsolete]
        public async Task PaymentAsync()
        {
            bool IsTranscationSuccess = false;
            CancellationTokenSource tokensource = new CancellationTokenSource();
            CancellationToken token = TokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Payment processing");
                await Task.Run(async () =>
                {
                    var Token = CreateToken();
                    Console.Write("Payment Gateway" + "Token:" + Token);
                    if (Token != null)
                    {
                        IsTranscationSuccess = MakePayment();
                    }
                    else
                    {
                        UserDialog.Instance.Alert("Bad card credentials", null, "ok");

                    }

                });
            }
            catch(Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write("Payment Gateway"+ex.Message);
            }
            finally
            {
                if(IsTranscationSuccess)
                {
                    UserDialogs.Instance.Alert("Success", "Success", "OK");
                    UserDialogs.Instance.HideLoading();

                }
                else
                {
                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert("Something went wrong", "Payment failed", "OK");
                    Console.Write("Payment Gateway" + "Payment Failure");
                }
            }
            }
        private void Button_Clicked(object sender, EventArgs e)
        {
            PaymentAsync();
        }
        public bool MakePayment()
        {
            try
            {
                StripeConfiguration.SetApiKey("sk_test_51LhokfSArx4pZrRYoDrbe3MtbwlppIAf2vbWPBMi2nt4CwGSEGkG7DILfjI80qfkt0d0PJpZHcG5OLE9u6yNNM6u00BOW3bzqt");
                var options = new ChargeCreateOptions
                {
                    Amount = (long)float.Parse("6000"),
                    Currency = "inr",
                    Description = "Charge for SaraDeveloper",
                    StatementDescriptor = "Custom Descripter",
                    Capture = true,
                    ReceiptEmail = "sujithravivekanandh@gmail.com",
                    Source = stripeToken.Id
                };
                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;    
            }
            catch (Exception ex)
            {
                Console.WriteLine("Payment Gateway(CreateCharge)" + ex.Message);
                throw ex;
            }
        }

        [Obsolete]
        public string CreateToken()
        {
            try
            {
                StripeConfiguration.SetApiKey(TestApikey);
                var service = new ChargeService();
                var tokenoption = new TokenCreateOptions()
                {
                    Card = new CreditCardOptions
                    {
                        Numbers = "4242424242424242",
                        ExpYear = 24,
                        ExpMonth = 12,
                        CvC = "565",
                        Name = "Sara",
                        AddressLine1 = "24",
                        AddressLine2 = "XYZ",
                        AddressCity = "Pune",
                        AddressZip="232433",
                        AddressState = "Maharastra",
                        AddressCountry = "India",
                        Currency="inr",
                    }
                };
                TokenService = new TokenService();
                stripeToken = TokenService.Create(tokenoption);
                return stripeToken.Id;

            }
            catch (Exception ex)
            {
                throw ex; 
                
            }
        }
        
    }
}
