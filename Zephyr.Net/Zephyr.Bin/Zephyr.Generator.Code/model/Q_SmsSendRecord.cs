using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SmsSendRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Tel{ get; set; }
        public string Content{ get; set; }
        public int Type{ get; set; }
        public DateTime SendTime{ get; set; }
        public string SendResult{ get; set; }
        public string SendResultRemark{ get; set; }
        public int SendCount{ get; set; }
        public DateTime? LastSendTime{ get; set; }
        public string LastSendResult{ get; set; }
        public string LastSendResultRemark{ get; set; }
    }
}
