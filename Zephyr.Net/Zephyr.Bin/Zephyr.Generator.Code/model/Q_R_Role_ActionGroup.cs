using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_R_Role_ActionGroup : IAggregateRoot
    {

        [PrimaryKey]
        public int RoleId{ get; set; }
        [PrimaryKey]
        public int ActionGroupId{ get; set; }
    }
}
