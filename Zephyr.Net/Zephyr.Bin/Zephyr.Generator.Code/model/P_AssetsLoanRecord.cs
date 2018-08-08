using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class P_AssetsLoanRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public decimal Amount{ get; set; }
        public int Day{ get; set; }
        public string Tel{ get; set; }
        public string Description{ get; set; }
        public int Uid{ get; set; }
        public string LoanNumber{ get; set; }
        public int State{ get; set; }
        public DateTime Addtime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
    }
}
