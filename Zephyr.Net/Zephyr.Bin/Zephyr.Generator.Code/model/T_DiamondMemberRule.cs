using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_DiamondMemberRule : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public decimal MinInvest{ get; set; }
        public decimal MaxInvest{ get; set; }
        public decimal IncomeLv{ get; set; }
        public string Description{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
    }
}
