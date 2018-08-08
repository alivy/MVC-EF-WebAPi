using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SendCreditEndRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? PayUid{ get; set; }
        public int? LoanUid{ get; set; }
        public string InvestNum{ get; set; }
        public string out_card_no{ get; set; }
        public string in_card_no{ get; set; }
        public string assets_no{ get; set; }
        public string auth_code{ get; set; }
        public string serial_no{ get; set; }
        public string third_reserved{ get; set; }
        public string BatchNo{ get; set; }
        public string Channel{ get; set; }
        public string OrgOrderId{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int State{ get; set; }
    }
}
