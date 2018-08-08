using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_BrowsingType : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string TypeName{ get; set; }
        public string Content{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string SendTime{ get; set; }
        public int? UserRange{ get; set; }
        public string Remarks{ get; set; }
    }
}
