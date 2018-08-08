using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Help : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Type{ get; set; }
        public string Title{ get; set; }
        public string Content{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
