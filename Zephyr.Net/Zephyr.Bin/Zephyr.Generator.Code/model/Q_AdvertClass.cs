using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_AdvertClass : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string ClassName{ get; set; }
        public int? UserId{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string UserName{ get; set; }
    }
}
