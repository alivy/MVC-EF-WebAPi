using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_TeamVoteRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? TeamId{ get; set; }
        public int? UserId{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
