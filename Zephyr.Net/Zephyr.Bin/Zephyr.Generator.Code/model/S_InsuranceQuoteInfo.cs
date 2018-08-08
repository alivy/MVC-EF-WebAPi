using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_InsuranceQuoteInfo : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OrderNumber{ get; set; }
        public string prvId{ get; set; }
        public string prvName{ get; set; }
        public int? taskState{ get; set; }
        public string taskStateDescription{ get; set; }
        public string msgType{ get; set; }
        public string IsEfc{ get; set; }
        public string IsTax{ get; set; }
        public string IsBiz{ get; set; }
        public string EfcStart{ get; set; }
        public string EfcEnd{ get; set; }
        public string EfcAmount{ get; set; }
        public string EfcPremium{ get; set; }
        public string EfcDiscountRate{ get; set; }
        public string EfcPolicyNo{ get; set; }
        public string TaxLateFee{ get; set; }
        public string TaxFee{ get; set; }
        public string BizStart{ get; set; }
        public string BizEnd{ get; set; }
        public string BizPremium{ get; set; }
        public string BizDiscountRate{ get; set; }
        public string BizNfcPremium{ get; set; }
        public string BizPolicyNo{ get; set; }
        public string TotalPremium{ get; set; }
        public string PayPremium{ get; set; }
        public DateTime? PayTime{ get; set; }
        public DateTime? PayValidTime{ get; set; }
        public string Remark{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
