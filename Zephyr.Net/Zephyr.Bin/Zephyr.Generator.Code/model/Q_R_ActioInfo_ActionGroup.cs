using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_R_ActioInfo_ActionGroup : IAggregateRoot
    {

        [PrimaryKey]
        public int ActionInfoId{ get; set; }
        [PrimaryKey]
        public int ActionGroupId{ get; set; }
    }
}
