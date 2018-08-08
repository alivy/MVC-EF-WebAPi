using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ActionInfo : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string ControllerName{ get; set; }
        public string ActionName{ get; set; }
        public int HttpMethod{ get; set; }
        public string Remark{ get; set; }
        public int DelFlag{ get; set; }
        public bool IsMenu{ get; set; }
        public DateTime AddTime{ get; set; }
        public int Sort{ get; set; }
        public string Code{ get; set; }
        public int? ParentId{ get; set; }
    }
}
