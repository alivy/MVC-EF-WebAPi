using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Sheng : IAggregateRoot
    {

        [Identity]
        public int id{ get; set; }
        public string sname{ get; set; }
    }
}
