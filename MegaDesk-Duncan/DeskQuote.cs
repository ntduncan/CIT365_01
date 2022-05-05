using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Duncan
{
    public class DeskQuote
    {
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }

        public string Shipping { get; set; }

        public Desk Desk { get; set; }

        public int RushDays { get; set; }


        public decimal getQuotePrice()
        {
            return new Decimal(0);
        }
    }

}
