using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_ActivityOperationType : IAggregateRoot
    {

        [PrimaryKey]
        public int Id{ get; set; }
        public int TypeNo{ get; set; }
        public string TypeName{ get; set; }
        public string ActivityNO{ get; set; }
    }
}
