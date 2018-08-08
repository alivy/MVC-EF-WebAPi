using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SafeCarQuoteService : ServiceBase<Q_SafeCarQuote>
    {
       
    }

    public class Q_SafeCarQuote : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? detailId{ get; set; }
        public string orderId{ get; set; }
        public string quoteNo{ get; set; }
        public string quoteStatus{ get; set; }
        public string companyType{ get; set; }
        public string insurerName{ get; set; }
        public string sumInsured{ get; set; }
        public string sumStdPrem{ get; set; }
        public string sumPayablePrem{ get; set; }
        public string sumBiPremium{ get; set; }
        public string sumCiPremium{ get; set; }
        public string discount{ get; set; }
        public string thisPayTax{ get; set; }
        public string prePayTax{ get; set; }
        public string delayPayTax{ get; set; }
        public string sumPayTax{ get; set; }
        public string actualValue{ get; set; }
        public string remark{ get; set; }
        public string payUrl{ get; set; }
        public string payAmount{ get; set; }
        public DateTime? addTime{ get; set; }
    }
}
