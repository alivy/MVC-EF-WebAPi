using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Shi : IAggregateRoot
    {

        [Identity]
        public int cid{ get; set; }
        public int? sid{ get; set; }
        public string cname{ get; set; }
    }
}
