using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_CreditoAttornRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int UserId{ get; set; }
        public string LoanNumber{ get; set; }
        public int SubjectId{ get; set; }
        public int SubjectBidId{ get; set; }
        public int InvestNum{ get; set; }
        public decimal TransferNum{ get; set; }
        public int SurplusPeriods{ get; set; }
        public string AuditOpinion{ get; set; }
        public int AuditUid{ get; set; }
        public DateTime? AuditTime{ get; set; }
        public DateTime ApplyTime{ get; set; }
        public int State{ get; set; }
    }
}
