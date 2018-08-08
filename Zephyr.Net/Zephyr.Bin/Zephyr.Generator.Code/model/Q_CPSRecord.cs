using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_CPSRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public decimal InvestNum{ get; set; }
        public DateTime InvestTime{ get; set; }
        public int Day{ get; set; }
        public int SubjectPayId{ get; set; }
        public int SubjectBidId{ get; set; }
        public DateTime RePayTime{ get; set; }
        public int RePayPeriods{ get; set; }
        public string TradeTime{ get; set; }
        public string Remarks{ get; set; }
        public int BidType{ get; set; }
    }
}
