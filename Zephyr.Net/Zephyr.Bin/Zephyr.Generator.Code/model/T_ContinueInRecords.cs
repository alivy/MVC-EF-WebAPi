using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_ContinueInRecords : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int TradeType{ get; set; }
        public string TradeRemark{ get; set; }
        public decimal TradeNum{ get; set; }
        public decimal? TradeRePayNum{ get; set; }
        public decimal RePayNum{ get; set; }
        public decimal? EnableNum{ get; set; }
        public string OrderNum{ get; set; }
        public DateTime AddTime{ get; set; }
        public int? SubjectPayId{ get; set; }
        public string LoanNumber{ get; set; }
        public int? SubjectBidId{ get; set; }
        public DateTime? TradeTime{ get; set; }
        public decimal UsableNum{ get; set; }
    }
}
