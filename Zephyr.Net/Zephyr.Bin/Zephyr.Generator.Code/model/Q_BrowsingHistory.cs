using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_BrowsingHistory : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Browser{ get; set; }
        public int TypeId{ get; set; }
        public DateTime AddTime{ get; set; }
        public string ClientIP{ get; set; }
    }
}
