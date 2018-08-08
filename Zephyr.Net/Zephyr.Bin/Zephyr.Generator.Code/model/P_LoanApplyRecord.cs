using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class P_LoanApplyRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int BagId{ get; set; }
        public string FullName{ get; set; }
        public int Days{ get; set; }
        public decimal Amount{ get; set; }
        public string Mobile{ get; set; }
        public string CardNumber{ get; set; }
        public string LoanUse{ get; set; }
        public int LoanObject{ get; set; }
        public int LoanType{ get; set; }
        public DateTime AddTime{ get; set; }
        public int State{ get; set; }
    }
}
