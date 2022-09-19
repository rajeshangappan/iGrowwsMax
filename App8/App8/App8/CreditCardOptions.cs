using Stripe;
using System.Diagnostics;

namespace App8
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    internal class CreditCardOptions : AnyOf<string, TokenCardOptions>
    {
        public CreditCardOptions(string value) : base(value)
        {
        }

        public CreditCardOptions(TokenCardOptions value) : base(value)
        {
        }

        public string Numbers { get; set; }
        public int ExpYear { get; set; }
        public int ExpMonth { get; set; }
        public string CvC { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressCity { get; set; }
        public string AddressZip { get; set; }
        public string AddressState { get; set; }
        public string AddressCountry { get; set; }
        public string Currency { get; set; }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}