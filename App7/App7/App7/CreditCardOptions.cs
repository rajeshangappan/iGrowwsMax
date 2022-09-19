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
    internal class CreditCardOptions
    {
        private object cvv;
        private object expireMonth;
        private object expireYear;

        public CreditCardOptions()
        {
            string cardno = CardNo;
            string expMonth = (string)expireMonth;
            string expYear = (string)expireYear;
            string CardCvv = (string)cvv;
            CreditCardOptions stripeOption = new CreditCardOptions();
            stripeOption.Number = cardno;
            stripeOption.ExpYear = Convert.ToInt64(expireYear);
            stripeOption.ExpMonth = Convert.ToInt64(expireMonth);
            stripeOption.CvC = CardCvv;
        }

        public long ExpMonth { get; internal set; }
        public string Number { get; internal set; }
        public long ExpYear { get; internal set; }
        public string CvC { get; internal set; }
        public string CardNo { get; }

        public static implicit operator AnyOf<object, object>(CreditCardOptions v)
        {
            throw new NotImplementedException();
        }
    }
}