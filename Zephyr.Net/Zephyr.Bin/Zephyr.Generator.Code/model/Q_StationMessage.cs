using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_StationMessage : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string From{ get; set; }
        public string To{ get; set; }
        public string Title{ get; set; }
        public string Content{ get; set; }
        public int? SendState{ get; set; }
        public int? ReceiveState{ get; set; }
        public int ReadState{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? ReadTime{ get; set; }
        public int ToId{ get; set; }
    }
}
