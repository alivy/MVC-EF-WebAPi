using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_FlowRegister : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? UserId{ get; set; }
        public int? RecommendUserId{ get; set; }
        public string AgePhase{ get; set; }
        public string MoblieNum{ get; set; }
        public int? RecommendCount{ get; set; }
        public int? GetNum{ get; set; }
        public int? IsNew{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
