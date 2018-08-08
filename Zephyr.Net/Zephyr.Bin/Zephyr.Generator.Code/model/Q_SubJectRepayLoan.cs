using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SubJectRepayLoan : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string LoanNumber{ get; set; }
        public int? RePayUid{ get; set; }
        public int? SubjectPayId{ get; set; }
        public int? RePayPeriods{ get; set; }
        public DateTime? RePayTime{ get; set; }
        public DateTime? ActualRepayTime{ get; set; }
        public decimal? CurPrincipal{ get; set; }
        public decimal? CurInterest{ get; set; }
        public int? OverdueDay{ get; set; }
        public decimal? OverDuePenalty{ get; set; }
        public int? RePayState{ get; set; }
        public string ContractNumber{ get; set; }
        public string RePayNumber{ get; set; }
        public string SerialNumber{ get; set; }
        public int RepaySign{ get; set; }
        public int WarrantUid{ get; set; }
        public int RepayMeth{ get; set; }
        public string Repay{ get; set; }
    }
}
