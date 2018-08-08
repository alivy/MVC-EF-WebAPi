using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_RewardProduct : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Title{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string Remark{ get; set; }
    }
}
