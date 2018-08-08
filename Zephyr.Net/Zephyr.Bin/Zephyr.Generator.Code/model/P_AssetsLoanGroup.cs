using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class P_AssetsLoanGroup : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string LoanNumber{ get; set; }
        public int SubjectPayId{ get; set; }
        public int BagId{ get; set; }
        public int LoanApplyId{ get; set; }
        public decimal Scale{ get; set; }
        public int State{ get; set; }
    }
}
