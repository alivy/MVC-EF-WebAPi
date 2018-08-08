using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class L_SafeCardFile : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public string CardFace{ get; set; }
        public string CardBack{ get; set; }
        public string HandCard{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? AuthTime{ get; set; }
        public int? State{ get; set; }
    }
}
