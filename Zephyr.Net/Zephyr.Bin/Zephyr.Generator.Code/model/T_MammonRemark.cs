using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_MammonRemark : IAggregateRoot
    {

        [PrimaryKey]
        public int Id{ get; set; }
        public string Character{ get; set; }
        public string Mammon{ get; set; }
        public string MammonRemark{ get; set; }
        public string MammonImg{ get; set; }
        public string MammonDescribe{ get; set; }
    }
}
