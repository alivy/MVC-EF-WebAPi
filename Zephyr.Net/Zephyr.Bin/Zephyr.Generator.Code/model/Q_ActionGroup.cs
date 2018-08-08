using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ActionGroup : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string GroupName{ get; set; }
        public int? GroupType{ get; set; }
        public int DelFlag{ get; set; }
        public int Sort{ get; set; }
        public DateTime AddTime{ get; set; }
        public string Icon{ get; set; }
    }
}
