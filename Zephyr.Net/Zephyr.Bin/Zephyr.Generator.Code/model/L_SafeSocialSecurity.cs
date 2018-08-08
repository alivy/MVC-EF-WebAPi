using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class L_SafeSocialSecurity : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int LoanUserInfoId{ get; set; }
        public string SocialSecurityNum{ get; set; }
        public string Account{ get; set; }
        public string Pwd{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime AuthTime{ get; set; }
        public int State{ get; set; }
    }
}
