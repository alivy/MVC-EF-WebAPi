using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_DiamondMember : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int Type{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime UpdateTime{ get; set; }
        public int IsDel{ get; set; }
    }
}
