using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class P_LoanApplyBag : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public string Title{ get; set; }
        public string Days{ get; set; }
        public decimal TotalAmount{ get; set; }
        public decimal SurplusNum{ get; set; }
        public decimal LockNum{ get; set; }
        public DateTime AddTime{ get; set; }
        public int AuditUid{ get; set; }
        public string AuditOpinion{ get; set; }
        public DateTime? AuditTime{ get; set; }
        public int ReviewUid{ get; set; }
        public string ReviewOpinion{ get; set; }
        public DateTime? ReviewTime{ get; set; }
        public int State{ get; set; }
    }
}
