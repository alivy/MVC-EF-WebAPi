using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_UserFollowRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? Uid{ get; set; }
        public string Content{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? OperationUid{ get; set; }
        public string Type{ get; set; }
        public string OperationUserName{ get; set; }
        public string UserName{ get; set; }
    }
}
