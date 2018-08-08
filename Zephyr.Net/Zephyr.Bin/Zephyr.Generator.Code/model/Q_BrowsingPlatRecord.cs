using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_BrowsingPlatRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int BrowsingPlatId{ get; set; }
        public string Browser{ get; set; }
        public string ClientIP{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
