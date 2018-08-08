using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class L_LoanApplyRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public decimal Amount{ get; set; }
        public int Periods{ get; set; }
        public int? LoanUsageId{ get; set; }
        public string LoanNumber{ get; set; }
        public string Description{ get; set; }
        public DateTime Addtime{ get; set; }
        public int ApplyType{ get; set; }
        public int State{ get; set; }
    }
}
