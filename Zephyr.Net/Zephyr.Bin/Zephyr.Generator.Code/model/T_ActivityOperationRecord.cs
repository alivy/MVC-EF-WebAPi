using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_ActivityOperationRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OpenId{ get; set; }
        public int? TypeNo{ get; set; }
        public int? Stutas{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
