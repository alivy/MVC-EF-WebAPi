using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_BrowsingPlatform : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string PlatformName{ get; set; }
        public string LinkName{ get; set; }
        public string LinkUrl{ get; set; }
        public int LinkType{ get; set; }
        public int VisitCount{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
