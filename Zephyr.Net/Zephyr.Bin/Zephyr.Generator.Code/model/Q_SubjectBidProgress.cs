using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SubjectBidProgress : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int SubjectPayId{ get; set; }
        public string LoanNumber{ get; set; }
        public decimal Amount{ get; set; }
        public decimal SurplusNum{ get; set; }
        public decimal? LockNum{ get; set; }
        public int? State{ get; set; }
    }
}
