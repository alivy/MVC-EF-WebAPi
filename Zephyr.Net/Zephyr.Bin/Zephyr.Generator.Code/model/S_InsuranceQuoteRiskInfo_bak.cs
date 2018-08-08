using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_InsuranceQuoteRiskInfo_bak : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OrderNumber{ get; set; }
        public string prvId{ get; set; }
        public string prvName{ get; set; }
        public string riskCode{ get; set; }
        public string riskName{ get; set; }
        public string notDeductible{ get; set; }
        public string amount{ get; set; }
        public string premium{ get; set; }
        public string nfcPremium{ get; set; }
        public DateTime? addTime{ get; set; }
    }
}
