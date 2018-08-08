using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class P_LoanApplyCompany : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int LoanApplyId{ get; set; }
        public string CompanyCard{ get; set; }
        public string CashFlowFile{ get; set; }
        public string Finances{ get; set; }
    }
}
