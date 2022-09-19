using System;
using Xamarin.Forms;
using Stripe;

namespace Stripe
{
    internal class CreditCardOptions
    {
        public string Number { get; internal set; }
        public int Cvc { get; internal set; }
        public int ExpYear { get; internal set; }
        public int ExpMonth { get; internal set; }

      
    }
}