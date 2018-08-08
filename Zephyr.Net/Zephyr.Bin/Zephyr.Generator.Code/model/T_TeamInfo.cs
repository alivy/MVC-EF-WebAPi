using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_TeamInfo : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string TeamName{ get; set; }
        public string TeamImg{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? VoteCount{ get; set; }
        public int? CanVote{ get; set; }
    }
}
