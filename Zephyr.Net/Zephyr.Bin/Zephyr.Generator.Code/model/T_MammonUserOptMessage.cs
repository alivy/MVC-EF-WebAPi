using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_MammonUserOptMessage : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OpenId{ get; set; }
        public int? OptState{ get; set; }
        public int? GodID{ get; set; }
        public int? FinancialID{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string UserName{ get; set; }
        public string Birthday{ get; set; }
        public string UserImg{ get; set; }
    }
}
