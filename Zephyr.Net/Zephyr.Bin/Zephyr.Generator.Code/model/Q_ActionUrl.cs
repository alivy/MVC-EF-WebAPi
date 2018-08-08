using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ActionUrl : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string actionGroup{ get; set; }
        public string actionDescription{ get; set; }
        public string actionUrl{ get; set; }
        public DateTime addTime{ get; set; }
    }
}
