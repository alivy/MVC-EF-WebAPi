using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_ActivityOperation : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OpenId{ get; set; }
        public int? ActivityNO{ get; set; }
        public DateTime? InTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
        public int? ClickNum{ get; set; }
        public string Patriotic{ get; set; }
        public int? EntryStyle{ get; set; }
    }
}
