using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SubjectLendRecord : IAggregateRoot
    {

        [Identity]
        public int id{ get; set; }
        public int SubjectPayId{ get; set; }
        public string LoanNumber{ get; set; }
        public int LoanUid{ get; set; }
        public int SubjectBidId{ get; set; }
        public int InvestUid{ get; set; }
        public string LendOrder{ get; set; }
        public decimal LendNum{ get; set; }
        public int LendState{ get; set; }
        public DateTime AddTime{ get; set; }
        public string SerialNumber{ get; set; }
        public string BatchNo{ get; set; }
        public decimal LvCharge{ get; set; }
    }
}
