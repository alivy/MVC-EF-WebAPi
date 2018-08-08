using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class L_LoanBank : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public string BankName{ get; set; }
        public string BankBranchName{ get; set; }
        public string BankNum{ get; set; }
        public int BankType{ get; set; }
        public string BankMobile{ get; set; }
        public string Province{ get; set; }
        public string City{ get; set; }
        public int IsATM{ get; set; }
        public int IsDel{ get; set; }
        public DateTime Addtime{ get; set; }
        public DateTime UpdateTime{ get; set; }
    }
}
