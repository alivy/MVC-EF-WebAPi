using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ActionUrlBlog : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string userAddress{ get; set; }
        public int actionId{ get; set; }
        public DateTime addTime{ get; set; }
    }
}
