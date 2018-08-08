using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_FlowShareRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string ClientId{ get; set; }
        public int? UserId{ get; set; }
        public string ShareUrl{ get; set; }
        public string Remark{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string ClientUserId{ get; set; }
        public string OpenId{ get; set; }
    }
}
