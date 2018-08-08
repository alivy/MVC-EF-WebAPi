using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class P_AssetsLoanSubjectBidRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int LoanApplyId{ get; set; }
        public int SubjectPayId{ get; set; }
        public string LoanNumber{ get; set; }
        public int SubjectBidId{ get; set; }
        public decimal InvestNum{ get; set; }
        public decimal Scale{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
