using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_DiamondMemberConfig : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Name{ get; set; }
        public int? Status{ get; set; }
        public string Description{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
        public int? TypeId{ get; set; }
    }
}
