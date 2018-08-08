using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class L_SafeMobileOperator : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int LoanUserInfoId{ get; set; }
        public string PhonePwd{ get; set; }
        public string MobileNum{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? AuthTime{ get; set; }
        public int IsDel{ get; set; }
        public int? State{ get; set; }
        public int Uid{ get; set; }
    }
}
