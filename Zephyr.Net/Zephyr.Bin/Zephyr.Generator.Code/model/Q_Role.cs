using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Role : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string RoleName{ get; set; }
        public int DelFlag{ get; set; }
        public int? RoleType{ get; set; }
        public DateTime AddTime{ get; set; }
        public string Remark{ get; set; }
    }
}
