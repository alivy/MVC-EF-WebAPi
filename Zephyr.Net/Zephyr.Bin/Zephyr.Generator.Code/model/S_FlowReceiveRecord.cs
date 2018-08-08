using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_FlowReceiveRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string FlowReceiveOrderNum{ get; set; }
        public int? State{ get; set; }
        public string Remark{ get; set; }
        public int? Type{ get; set; }
        public int? UserId{ get; set; }
        public int? SendCount{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
