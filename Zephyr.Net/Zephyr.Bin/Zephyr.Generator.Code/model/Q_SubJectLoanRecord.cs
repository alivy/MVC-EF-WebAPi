using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SubJectLoanRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int ReUid{ get; set; }
        public string Batch{ get; set; }
        public int TotalItem{ get; set; }
        public int State{ get; set; }
        public int SubjectPayId{ get; set; }
        public string LoanNumber{ get; set; }
        public int SubJectRepayLoanId{ get; set; }
        public int Count{ get; set; }
        public int WarrantUid{ get; set; }
        public int RepayMeth{ get; set; }
    }
}
