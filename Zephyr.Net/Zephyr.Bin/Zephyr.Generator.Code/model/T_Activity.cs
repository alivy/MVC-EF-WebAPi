using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_Activity : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? ActivityNO{ get; set; }
        public string ActivityName{ get; set; }
        public DateTime? StatusTime{ get; set; }
        public DateTime? EndTime{ get; set; }
    }
}
