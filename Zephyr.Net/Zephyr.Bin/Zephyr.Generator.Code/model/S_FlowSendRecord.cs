using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_FlowSendRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? ProductId{ get; set; }
        public string OrderNum{ get; set; }
        public string MobileNum{ get; set; }
        public int? State{ get; set; }
        public string Remark{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? FlowReceiveRecordId{ get; set; }
        public string FlowReceiveOrderNum{ get; set; }
    }
}
