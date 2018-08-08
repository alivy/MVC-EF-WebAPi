using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_FlowRewardGetRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? UserId{ get; set; }
        public int? FlowRewardConfigId{ get; set; }
        public int? TerminalType{ get; set; }
        public int? State{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
