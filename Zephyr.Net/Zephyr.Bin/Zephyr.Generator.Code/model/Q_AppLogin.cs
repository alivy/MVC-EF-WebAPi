using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_AppLogin : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public DateTime LoginTime{ get; set; }
        public DateTime ExpirationTime{ get; set; }
        public string UDID{ get; set; }
        public string Browser{ get; set; }
    }
}
