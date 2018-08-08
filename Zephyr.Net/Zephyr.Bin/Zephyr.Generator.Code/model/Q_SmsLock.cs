using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SmsLock : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string ip{ get; set; }
        public int? State{ get; set; }
        public DateTime? Addtime{ get; set; }
        public DateTime? Uptime{ get; set; }
    }
}
