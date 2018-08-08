using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SubJectRepay : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string LoanNumber{ get; set; }
        public int? Uid{ get; set; }
        public int? SubjectPayId{ get; set; }
        public int? SubjectBidId{ get; set; }
        public int? RePayPeriods{ get; set; }
        public DateTime? RePayTime{ get; set; }
        public DateTime? ActualRepayTime{ get; set; }
        public decimal? CurPrincipal{ get; set; }
        public decimal? CurInterest{ get; set; }
        public decimal? InComePrincipal{ get; set; }
        public decimal? Profit{ get; set; }
        public decimal? InterestMgtFee{ get; set; }
        public int? IsOverdue{ get; set; }
        public int? OverdueDay{ get; set; }
        public decimal? OverDuePenalty{ get; set; }
        public string RePayNumber{ get; set; }
        public int? RePayUid{ get; set; }
        public int? RePayState{ get; set; }
        public string OrderNum{ get; set; }
        public decimal? BidInterest{ get; set; }
        public decimal? RewardInterest{ get; set; }
        public string SerialNumber{ get; set; }
    }
}
