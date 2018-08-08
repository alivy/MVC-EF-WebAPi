using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_RepairBlog : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Content{ get; set; }
        public int? State{ get; set; }
        public string UserName{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string Type{ get; set; }
    }
}
