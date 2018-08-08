using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Qu : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int qid{ get; set; }
        public int sid{ get; set; }
        public int cid{ get; set; }
        public string qname{ get; set; }
    }
}
