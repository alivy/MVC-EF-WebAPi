using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_R_UserInfo_Dept : IAggregateRoot
    {

        [PrimaryKey]
        public int DeptId{ get; set; }
        [PrimaryKey]
        public int UserId{ get; set; }
    }
}
