using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_PlatformUser : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? FormId{ get; set; }
        public int? UserId{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? Type{ get; set; }
    }
}
