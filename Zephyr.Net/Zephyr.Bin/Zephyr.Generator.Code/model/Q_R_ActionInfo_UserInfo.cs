using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_R_ActionInfo_UserInfo : IAggregateRoot
    {

        [PrimaryKey]
        public int UserId{ get; set; }
        [PrimaryKey]
        public int ActionInfoId{ get; set; }
    }
}
