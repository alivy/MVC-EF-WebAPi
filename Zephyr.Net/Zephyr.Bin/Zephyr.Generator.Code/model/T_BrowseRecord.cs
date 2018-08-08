using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_BrowseRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OpenId{ get; set; }
        public string TjrId{ get; set; }
        public string Url{ get; set; }
        public string ReferUrl{ get; set; }
        public int BroTime{ get; set; }
        public DateTime? InTime{ get; set; }
        public DateTime? OutTime{ get; set; }
        public string System{ get; set; }
        public string Browser{ get; set; }
        public int? ActivityNO{ get; set; }
    }
}
